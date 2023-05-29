using FarmCentralST10091815.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//----------------------------------------------------------------o0 Start 0o-------------------------------------------------------//

namespace FarmCentralST10091815
{
    public partial class Farmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void FarmLoginButton_Click(object sender, EventArgs e)
        {
            string farmerUsername = txtFarmerUsername.Text.Trim();
            string farmerPassword = txtFarmerPassword.Text.Trim();

            string hashedPasswordFromDatabase = GetHashedPasswordFromDatabase(farmerUsername);

            if (hashedPasswordFromDatabase != null)
            {
                // Verify the entered password against the hashed password retrieved from the database
                if (VerifyPassword(farmerPassword, hashedPasswordFromDatabase))
                {
                    Response.Redirect("~/FarmerDash.aspx");
                }
                else
                {
                    lblErrorMessage.Text = "Invalid username or password";
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        private string GetHashedPasswordFromDatabase(string username)
        {
            DBconnectionS dbConnection = new DBconnectionS();
            string hashedPassword = dbConnection.GetFarmerHashedPassword(username);
            return hashedPassword;
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        private bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the entered password against the hashed password
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = Convert.FromBase64String(hashedPassword);
                byte[] hashedInputBytes = sha256.ComputeHash(passwordBytes);

                return hashedInputBytes.SequenceEqual(hashedBytes);
            }
        }
    }
}
//----------------------------------------------------------------o0 End 0o---------------------------------------------------------//