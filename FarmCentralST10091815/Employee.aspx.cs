using FarmCentralST10091815.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//----------------------------------------------------------------o0 Start 0o-------------------------------------------------------//

namespace FarmCentralST10091815
{
    public partial class Employee : System.Web.UI.Page
    {
        private DBconnectionS datab = new DBconnectionS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void EmpLoginButton_Click(object sender, EventArgs e)
        {
            string empUsername = txtEmpUsername.Text;
            string empPassword = txtEmpPassword.Text;

            string dbConnection = datab.GetEmployeePassword(empUsername);

            if (dbConnection !=null && dbConnection.Equals(empPassword))
            {
                // Redirect to employee dashboard or another page
                Response.Redirect("~/EmployeeDash.aspx");
                txtEmpUsername.Text = string.Empty;
                txtEmpPassword.Text = string.Empty;
            }
            else
            {
                lblErrorMessage.Text = "Invalid username or password.";
            }
        }
    }
}

//----------------------------------------------------------------o0 End 0o---------------------------------------------------------//