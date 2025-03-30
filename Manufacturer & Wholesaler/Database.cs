using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Manufacturer___Wholesaler
{
    public class Database
    {
        private static string dbPath = "Data Source=C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\OscarMbo.db;Version=3;";
        private static SQLiteConnection conn;

        // Initialize the database and create tables if they don't exist
        public static void InitializeDatabase()
        {
            if (!File.Exists("OscarMbo.db"))
            {
                SQLiteConnection.CreateFile("OscarMbo.db");
            }

            using (conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                // Create users table if not exists
                string query = @"CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT UNIQUE NOT NULL,
                            password TEXT NOT NULL,
                            role TEXT NOT NULL
                         );";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

                // Insert default admin if not exists
                string insertAdmin = @"INSERT OR IGNORE INTO users (username, password, role) 
                               VALUES ('Admin', 'admin12345', 'Admin');";
                cmd = new SQLiteCommand(insertAdmin, conn);
                cmd.ExecuteNonQuery();

                // Create products table
                string productTableQuery = @"CREATE TABLE IF NOT EXISTS products (
                                               id INTEGER PRIMARY KEY AUTOINCREMENT,
                                               productName TEXT NOT NULL,
                                               shortDescription TEXT,
                                               fullDescription TEXT,
                                               imagePath TEXT
                                             );";
                cmd = new SQLiteCommand(productTableQuery, conn);
                cmd.ExecuteNonQuery();

                // Insert sample products if none exist
                string countQuery = "SELECT COUNT(*) FROM products";
                cmd = new SQLiteCommand(countQuery, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    string insertProducts = @"
                    INSERT INTO products (productName, shortDescription, fullDescription, imagePath)
                    VALUES 
                    ('Liquid Dishwashing Soap', 'A gentle liquid dishwashing soap', 'This is a full description of Liquid Dishwashing Soap.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Liquid Dishwashing Soap.jpeg'),
                    ('Laundry Detergent (Liquid)', 'Effective liquid detergent', 'Full details for Laundry Detergent (Liquid).', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Laundry Detergent (Liquid).jpg'),
                    ('Laundry Detergent (Powder)', 'Powerful powder detergent', 'Full details for Laundry Detergent (Powder).', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Laundry Detergent (Powder).jpeg'),
                    ('Hand Wash (Liquid Soap)', 'Cleans hands effectively', 'Full details for Hand Wash (Liquid Soap).', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Hand Wash (Liquid Soap).jpeg'),
                    ('Floor Cleaner (Pine Disinfectant)', 'Fresh pine scent floor cleaner', 'Full details for Floor Cleaner (Pine Disinfectant).', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Floor Cleaner (Pine Disinfectant).jpeg'),
                    ('Glass Cleaner', 'Streak-free glass cleaning', 'Full details for Glass Cleaner.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Glass Cleaner.jpg'),
                    ('Toilet Cleaner', 'Deep cleaning toilet solution', 'Full details for Toilet Cleaner.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Toilet Cleaner.jpeg'),
                    ('Car Wash Shampoo', 'Gentle car wash shampoo', 'Full details for Car Wash Shampoo.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Car Wash Shampoo.jpg'),
                    ('Dishwashing Powder', 'Effective dishwashing powder', 'Full details for Dishwashing Powder.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Finish Dishwashing powdwer.jpeg'),
                    ('Fabric Softener', 'Softens and freshens fabrics', 'Full details for Fabric Softener.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Fabric softener.jpeg'),
                    ('Oven & Grill Cleaner', 'Removes stubborn grease', 'Full details for Oven & Grill Cleaner.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Oven & Grill Cleaner.jpeg'),
                    ('Hand Sanitizer', 'Kills 99.9% germs', 'Full details for Hand Sanitizer.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Hand Sanitizer.jpeg'),
                    ('Shampoo', 'Gentle shampoo for daily use', 'Full details for Shampoo.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Shampoo.jpeg'),
                    ('Bleach (Disinfectant Solution)', 'Strong disinfectant solution', 'Full details for Bleach (Disinfectant Solution).', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Bleach (Disinfectant Solution).jpeg'),
                    ('Antibacterial Surface Cleaner', 'Cleans and disinfects surfaces', 'Full details for Antibacterial Surface Cleaner.', 'C:\\Users\\User\\Desktop\\PROJECTS\\C# Forms Test && Run\\Manufacturer & Wholesaler\\Images\\Antibacterial Surface Cleaner.jpeg');
                    ";
                    cmd = new SQLiteCommand(insertProducts, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get a new connection
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(dbPath);
        }

        // Method to execute an SQL query (Insert, Update, Delete)
        public void ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to get data as a DataTable
        public DataTable GetDataTable(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
