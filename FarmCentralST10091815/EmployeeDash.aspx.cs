using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using FarmCentralST10091815.Classes;
using System.Data.Common;
using System.Data;
using System.Data.Odbc;

//----------------------------------------------------------------o0 Start 0o-------------------------------------------------------//

namespace FarmCentralST10091815
{
    public partial class EmployeeDash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBconnectionS dbConnection = new DBconnectionS();

                DataTable productsTable = dbConnection.GetAllProducts();
                GridViewProducts.DataSource = productsTable;
                GridViewProducts.DataBind();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {
            //Recieving the input values from the textboxes
            string FarmerUsername = txtRegFarmerUsername.Text.Trim();
            string FarmerEmail = txtRegFarmerAddress.Text.Trim();
            string FarmerContact = txtRegFarmerContact.Text.Trim();
            string FarmerPassword = regFarmerPassword.Text.Trim();
            string confirmPassword = confFarmerPassword.Text.Trim();
            
            //Checking if any of the required fields are left empty
            if(string.IsNullOrEmpty(FarmerUsername) || string.IsNullOrEmpty(FarmerEmail) || string.IsNullOrEmpty(FarmerContact) ||
               string.IsNullOrEmpty(FarmerPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                lblErrorMessage.Text = "Please fill out all of the fields";
                return;
            }

            //Making sure that the password and confirm password matches
            if (FarmerPassword != confirmPassword)
            {
                lblErrorMessage.Text = "Passwords do not match";
                return;
            }

            //Hashing the password with the salt
            string hashedPassword = HashPassword(FarmerPassword);

            //Clearing the input fields
            txtRegFarmerUsername.Text = string.Empty;
            txtRegFarmerAddress.Text = string.Empty;
            txtRegFarmerContact.Text = string.Empty;
            regFarmerPassword.Text = string.Empty;
            confFarmerPassword.Text = string.Empty;

            DBconnectionS dbConnection = new DBconnectionS();
            dbConnection.InsertFarmerData(FarmerUsername, FarmerEmail, FarmerContact, hashedPassword);

            //Display success message if values have been stored
            lblErrorMessage.Text = "A new Farmer has been added successfully";
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void GridViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------//

        private string HashPassword(string password)
        {
            //Hashing the passowrd
            using(var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                string hashedPassword = Convert.ToBase64String(hashedBytes);

                return hashedPassword;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void DropDownListSelectFarmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> farmerUsernames = GetFarmerUsernames();

            DropDownListSelectFarmer.DataSource = farmerUsernames;
            DropDownListSelectFarmer.DataBind();

            string DisplayFarmerData = DropDownListSelectFarmer.SelectedValue;
            lblErrorMessage.Text = DisplayFarmerData;

        }

        //--------------------------------------------------------------------------------------------------------------------------//

        private List<string> GetFarmerUsernames()
        {
            List<string> farmerUsernames = new List<string>();

            // Create an instance of the DBconnectionS class
            DBconnectionS dbConnection = new DBconnectionS();

            // Retrieve the farmer usernames from the database
            farmerUsernames = dbConnection.GetFarmerUsernames();

            return farmerUsernames;
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        public DataTable GetAllProducts()
        {
            DBconnectionS dbConnection = new DBconnectionS();
            return dbConnection.GetAllProducts();
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void btnFilterProducts_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text.Trim();

            if (!string.IsNullOrEmpty(productID))
            {
                DBconnectionS dbConnection = new DBconnectionS();
                DataTable productsTable = dbConnection.GetProductsByProductID(productID);

                GridViewProducts.DataSource = productsTable;
                GridViewProducts.DataBind();
            }
            else
            {
                lblErrorMessage.Text = "Invalid ProductID";
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void btnEmpLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}
//----------------------------------------------------------------o0 End 0o---------------------------------------------------------//