using FarmCentralST10091815.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//----------------------------------------------------------------o0 Start 0o-------------------------------------------------------//

namespace FarmCentralST10091815
{
    public partial class FarmerDash : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendVegetable_Click(object sender, EventArgs e)
        {
            string vegetableName = txtVegetableName.Text;
            DateTime harvestingDate = CalendarVegetable.SelectedDate;

            DBconnectionS dbConnection = new DBconnectionS();

            //Insert the vegetable into the database
            dbConnection.InsertVegetable(vegetableName, harvestingDate);

            //Clear the input fields
            txtVegetableName.Text = "";
            CalendarVegetable.SelectedDate = DateTime.Today;

            //Display a success message
            lblErrorMessage.Text = "Vegetable added successfully!";
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void btnSendFruit_Click(object sender, EventArgs e)
        {
            string fruitName = txtFruitName.Text;
            DateTime harvestingDate = Calendar1.SelectedDate;

            DBconnectionS dbConnection = new DBconnectionS();

            //Insert the fruit into the database
            dbConnection.InsertFruit(fruitName, harvestingDate);

            //Clear the input fields
            txtFruitName.Text = "";
            Calendar1.SelectedDate = DateTime.Today;

            //Display a success message
            lblErrorMessage.Text = "Fruit added successfully!";
        }

        //--------------------------------------------------------------------------------------------------------------------------//

        protected void btnSendMeat_Click(object sender, EventArgs e)
        {
            string meatName = txtMeatName.Text;
            DateTime harvestingDate = Calendar2.SelectedDate;

            DBconnectionS dbConnection = new DBconnectionS();

            //Insert the meat into the database
            dbConnection.InsertMeat(meatName, harvestingDate);

            //Clear the input fields
            txtMeatName.Text = "";
            Calendar2.SelectedDate = DateTime.Today;

            //Display a success message
            lblErrorMessage.Text = "Meat added successfully!";
        }

        //--------------------------------------------------------------------------------------------------------------------------//

    }
}
//----------------------------------------------------------------o0 End 0o---------------------------------------------------------//