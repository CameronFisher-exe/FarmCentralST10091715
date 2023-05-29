using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

//----------------------------------------------------------------o0 Start 0o-------------------------------------------------------//

namespace FarmCentralST10091815.Classes
{
    public class DBconnectionS
    {
        private string MyConnString;

        public DBconnectionS()
        {
            MyConnString = ConfigurationManager.ConnectionStrings["FarmCentralST10091815.Properties.Settings.FarmCentDB"].ConnectionString;
        }

        //----------------------------------------------------o0 Inserting 0o-------------------------------------------------------//

        #region Inserting Farmer Data Into The Database
        public void InsertFarmerData(string username, string email, string contact, string hashedPassword)
        {
            using (SqlConnection conn = new SqlConnection(MyConnString))
            {
                string query = "INSERT INTO Farmers (FarmerUsername, FarmerEmail, FarmerContact, FarmerPassword) VALUES (@Username, @Email, @Contact, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------//

        #region Inserting Product Data Into The Database
        public void InsertVegetable(string vegetableName, DateTime harvestingDate)
        {
            using (SqlConnection connection = new SqlConnection(MyConnString))
            {
                string productQuery = "INSERT INTO Products (ProductID, ProductName, HarvestingDate) VALUES (@ProductID, @ProductName, @HarvestingDate); SELECT SCOPE_IDENTITY();";
                string vegetableQuery = "INSERT INTO Vegetables (ProductID, VegetableName) VALUES (@ProductID, @VegetableName)";

                using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                {
                    string productID = Guid.NewGuid().ToString(); // Generate a unique identifier for ProductID

                    productCommand.Parameters.AddWithValue("@ProductID", productID);
                    productCommand.Parameters.AddWithValue("@ProductName", vegetableName);
                    productCommand.Parameters.AddWithValue("@HarvestingDate", harvestingDate);

                    connection.Open();
                    productCommand.ExecuteNonQuery();

                    using (SqlCommand vegetableCommand = new SqlCommand(vegetableQuery, connection))
                    {
                        vegetableCommand.Parameters.AddWithValue("@ProductID", productID);
                        vegetableCommand.Parameters.AddWithValue("@VegetableName", vegetableName);

                        vegetableCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public void InsertFruit(string fruitName, DateTime harvestingDate)
        {
            using (SqlConnection connection = new SqlConnection(MyConnString))
            {
                string productQuery = "INSERT INTO Products (ProductID, ProductName, HarvestingDate) VALUES (@ProductID, @ProductName, @HarvestingDate); SELECT SCOPE_IDENTITY();";
                string fruitQuery = "INSERT INTO Fruits (ProductID, FruitName) VALUES (@ProductID, @FruitName)";

                using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                {
                    string productID = Guid.NewGuid().ToString();

                    productCommand.Parameters.AddWithValue("@ProductID", productID);
                    productCommand.Parameters.AddWithValue("@ProductName", fruitName);
                    productCommand.Parameters.AddWithValue("@HarvestingDate", harvestingDate);

                    connection.Open();
                    productCommand.ExecuteNonQuery();

                    using (SqlCommand fruitCommand = new SqlCommand(fruitQuery, connection))
                    {
                        fruitCommand.Parameters.AddWithValue("@ProductID", productID);
                        fruitCommand.Parameters.AddWithValue("@FruitName", fruitName);

                        fruitCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public void InsertMeat(string meatName, DateTime harvestingDate)
        {
            using (SqlConnection connection = new SqlConnection(MyConnString))
            {
                string productQuery = "INSERT INTO Products (ProductID, ProductName, HarvestingDate) VALUES (@ProductID, @ProductName, @HarvestingDate); SELECT SCOPE_IDENTITY();";
                string meatQuery = "INSERT INTO Meats (ProductID, MeatName) VALUES (@ProductID, @MeatName)";

                using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                {
                    string productID = Guid.NewGuid().ToString();

                    productCommand.Parameters.AddWithValue("@ProductID", productID);
                    productCommand.Parameters.AddWithValue("@ProductName", meatName);
                    productCommand.Parameters.AddWithValue("@HarvestingDate", harvestingDate);

                    connection.Open();
                    productCommand.ExecuteNonQuery();

                    using (SqlCommand meatCommand = new SqlCommand(meatQuery, connection))
                    {
                        meatCommand.Parameters.AddWithValue("@ProductID", productID);
                        meatCommand.Parameters.AddWithValue("@MeatName", meatName);

                        meatCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        #endregion


        //----------------------------------------------------o0 Retrieving 0o------------------------------------------------------//

        #region Retrieving The Farmers Hashed Pasword From The Database
        public string GetFarmerHashedPassword(string username)
        {
            using (SqlConnection conn = new SqlConnection(MyConnString))
            {
                string query = "SELECT FarmerPassword FROM Farmers WHERE FarmerUsername = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }

            return null;
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------//

        #region Retrieving The Employees Hashed Password From The Database
        public string GetEmployeePassword(string empUsername)
        {
            string password = null;
            string query = "SELECT EmployeePassword FROM Employees WHERE EmployeeUsername = @Username";

            using (SqlConnection conn = new SqlConnection(MyConnString))
            {

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", empUsername);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        password = result.ToString();
                    }
                }
            }

            return password;
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------//

        #region Retrieving The Farmers Username From The Database
        public List<string> GetFarmerUsernames()
        {
            List<string> farmerUsernames = new List<string>();

            using (SqlConnection conn = new SqlConnection(MyConnString))
            {
                string query = "SELECT FarmerUsername FROM Farmers";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string username = reader["FarmerUsername"].ToString();
                        farmerUsernames.Add(username);
                    }

                    reader.Close();
                }
            }

            return farmerUsernames;
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------//

        #region Retrieving All Products From The Database
        public DataTable GetAllProducts()
        {
            DataTable productsTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(MyConnString))
            {
                string query = "SELECT * FROM Products";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(productsTable);
                }
            }

            return productsTable;
        }
        #endregion

        //--------------------------------------------------------------------------------------------------------------------------//

        public DataTable GetProductsByProductID(string productID)
        {
            DataTable productsTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(MyConnString))
            {
                string query = "SELECT * FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(productsTable);
                }
            }

            return productsTable;
        }
    }
}
//----------------------------------------------------------------o0 End 0o---------------------------------------------------------//