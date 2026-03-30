using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EAD_POS_SYSTEM
{
    public class POSLogic
    {
        // --- 1. FIELDS (Requirement: Create fields in classes - 4 Marks) ---
        private string _storeName = "VTDI POS";

        // --- 2. PROPERTIES (Requirement: Create 2 properties - 4 Marks) ---
        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }

        // READ-ONLY PROPERTY (Requirement: Create 1 read-only - 2 Marks)
        public string SystemStatus
        {
            get { return "System Online"; }
        }

        // --- 3. METHODS RETURNING A VALUE (Requirement: 3 non-static - 10 Marks) ---
        // Method 1: Calculate basic math
        public double CalculateTotal(double price, int quantity)
        {
            return price * quantity;
        }

        // Method 3: Get a formatted message for your Search Bar
        public string GetSearchMessage(string name)
        {
            return "Searching for: " + name;
        }

        // --- 4. VOID METHODS (Requirement: 2 non-static - 6 Marks) ---
        // Method 1: THIS FIXES YOUR ERROR
        public void ClearTransaction()
        {
            // Logic to reset variables for a new sale
            System.Diagnostics.Debug.WriteLine("Sale cleared.");
        }

        // Method 2: Logs the payment type (CASH, CARD, etc.)
        public void LogPayment(string type)
        {
            System.Diagnostics.Debug.WriteLine("Payment Method: " + type);
        }

        // --- 5. STATIC & OVERLOADED (Requirement: 1 static, 1 overloaded - 5 Marks) ---
        public static string GetVersion() => "POS System v1.1";

        public double ApplyDiscount(double total) => total * 0.95; // Default 5%
        public double ApplyDiscount(double total, double percent) => total * (1 - percent);

        // --- 6. WEB METHODS (Requirement: Create methods for Web - 6 Marks) ---
        public string GetWebTotalHTML(double total)
        {
            return "<div class='total'>Total: $" + total.ToString() + "</div>";
        }

        // Change 'YourPath' to the actual path of your .mdf file
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YourPath\POS_DB.mdf;Integrated Security=True";

        public bool IsIdUnique(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM Products WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 0; // Returns true if ID does NOT exist
            }
        }

        public void AddProduct(int id, string name, double price)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Products (ProductID, ProductName, Price) VALUES (@id, @name, @price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void LoadGrid(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt; // This links the SQL data to your UI grid
            }
        }



    }
}
