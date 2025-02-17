using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public class DatabaseConnection
{
    public static void ExecuteQuery(string qr)
    {
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        SqlConnection con = new SqlConnection(connectionString);

        con.Open();

        SqlCommand cmd = new SqlCommand(qr, con);
        cmd.ExecuteNonQuery();

        con.Close();
    }

    public static int getUserCount(string username, string password)
    {

        int userExists = 0;

        // Simulated user input (replace with actual input from your login form)
        string inputUsername = username;
        string inputPassword = password;

        // Connection string (replace with your actual database details)
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        // SQL query to check username and password
        string query = "SELECT COUNT(*) FROM Users WHERE user_name COLLATE Latin1_General_CS_AS = @Username AND password COLLATE Latin1_General_CS_AS = @Password";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Username", inputUsername);
                    command.Parameters.AddWithValue("@Password", inputPassword);

                    // Execute the query and get the result
                    userExists = (int)command.ExecuteScalar();

                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        return userExists;
    }


    public static string GetFullName(string userName)
    {
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        string fullName = string.Empty;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT full_name FROM Users WHERE user_name = @user_name";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add the parameter to prevent SQL injection
                command.Parameters.AddWithValue("@user_name", userName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    fullName = reader["full_name"].ToString();
                }

                reader.Close();
            }
        }

        return fullName;
    }

    public static int get_userId(string userName)
    {
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        int userId = -1;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT user_id FROM users WHERE user_name = @user_name";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@user_name", userName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
        }

        return userId;
    }


    public static List<Outlet> getOutlets(string userName)
    {
        List<Outlet> outlets = new List<Outlet>();

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        int userId = get_userId(userName);

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT outlet_id, outlet_name, outlet_address, outlet_contact FROM outlet WHERE user_id = @UserId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Outlet outlet = new Outlet(
                            reader.GetInt32(0),   
                            reader.GetString(1),  
                            reader.GetString(2),  
                            reader.GetString(3)  
                        );
                        outlets.Add(outlet);
                    }
                }
            }
        }

        return outlets;
    }

    public static List<Medicine> getAllMedicine()
    {
        List<Medicine> medicines = new List<Medicine>();

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT medicine_id, medicine_name, medicine_description, manufacturer, grp FROM Medicine";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medicine medicine = new Medicine(
                                                        reader.GetInt32(0),
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        reader.GetString(4)
                                                    );

                    medicines.Add(medicine);
                }
            }
        }

        return medicines;
    }


    public static List<Medicine> getMedKeyWord(string keyWord)
    {
        List<Medicine> medicines = new List<Medicine>();

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT medicine_id, medicine_name, medicine_description, manufacturer, grp " +
                           "FROM Medicine " +
                           "WHERE medicine_name LIKE @keyWord OR manufacturer LIKE @keyWord OR grp LIKE @keyWord OR medicine_description LIKE @keyWord";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@keyWord", "%" + keyWord + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medicine medicine = new Medicine(
                                                        reader.GetInt32(0),
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        reader.GetString(4)
                                                    );

                    medicines.Add(medicine);
                }
            }
        }

        return medicines;
    }

    public static void updateOutletDetails(int outlet_id, string outlet_name, string outlet_address, string outlet_contact)
    {
        string query = "UPDATE outlet SET outlet_name = @name, outlet_address = @address, outlet_contact = @contact WHERE outlet_id = @id";

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";


        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@name", outlet_name);
            cmd.Parameters.AddWithValue("@address", outlet_address);
            cmd.Parameters.AddWithValue("@contact", outlet_contact);
            cmd.Parameters.AddWithValue("@id", outlet_id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static void removeOutlet(int outlet_id)
    {
        string query = "DELETE FROM outlet WHERE outlet_id = @outlet_id";

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@outlet_id", outlet_id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static void addToStock(int medicineId, string outletName, int quantity, DateTime expDate, string userName)
    {
        int outletId = 0;

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        string query = "SELECT outlet_id FROM outlet WHERE outlet_name = @outletName AND user_id = (SELECT user_id FROM users WHERE user_name = @userName)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@outletName", outletName);
                    command.Parameters.AddWithValue("@userName", userName);

                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        outletId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Handle case where no matching record is found
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }


        query = "INSERT INTO stock (medicine_id, outlet_id, quantity, exp_date) " +
                   "VALUES (@medicineId, @outletId, @quantity, @expDate)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@medicineId", medicineId);
                    command.Parameters.AddWithValue("@outletId", outletId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@expDate", expDate);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    public static List<Stock> getStockList(int outletId)
    {
        List<Stock> stockList = new List<Stock>();

        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        string query = "SELECT stock_id, outlet_id, medicine_id, quantity, exp_date FROM stock WHERE outlet_id = @outletId";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@outletId", outletId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stock stock = new Stock(
                        reader.GetInt32(0),  
                        reader.GetInt32(1),  
                        reader.GetInt32(2),  
                        reader.GetInt32(3),  
                        reader.GetDateTime(4) 
                    );

                    stockList.Add(stock);
                }
            }
        }

        return stockList;
    }

    public static string getMedicineName(int medicineId)
    {
        string medicineName = null;
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        string query = "SELECT medicine_name FROM medicine WHERE medicine_id = @medicineId";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@medicineId", medicineId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    medicineName = result.ToString();
                }
            }
        }
        return medicineName;
    }

    public static void removeStock(int stockId, int value)
    {
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // Retrieve the current quantity for the given stock_id
            string selectQuery = "SELECT quantity FROM stock WHERE stock_id = @stockId";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@stockId", stockId);

            object result = selectCmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal currentQuantity = Convert.ToDecimal(result);

                // Check if the current quantity is equal to the value to remove
                if (currentQuantity == value)
                {
                    // If they are equal, delete the row
                    string deleteQuery = "DELETE FROM stock WHERE stock_id = @stockId";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@stockId", stockId);
                    deleteCmd.ExecuteNonQuery();
                }
                else
                {
                    // If not, deduct the quantity
                    decimal newQuantity = currentQuantity - value;

                    string updateQuery = "UPDATE stock SET quantity = @newQuantity WHERE stock_id = @stockId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                    updateCmd.Parameters.AddWithValue("@stockId", stockId);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }
    }

    public static void removeStock(int outlet_id)
    {
        string query = "DELETE FROM stock WHERE outlet_id = @outlet_id";
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        using (SqlConnection conn = new SqlConnection(connectionString)) // Use your connection string
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@outlet_id", outlet_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); // Execute the delete command
            }
            catch (Exception ex)
            {
                // Handle exceptions
                //MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public static bool nameExists(string userName)
    {
        string connectionString = "Data Source=LAPTOP-0CKI5KGV\\SQLEXPRESS;Initial Catalog=MediTrack;Integrated Security=True;Trust Server Certificate=True";
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM users WHERE user_name = @userName";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    return true;
                }
            }
        }

        return false;
    }


}