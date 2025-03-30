using Manufacturer___Wholesaler.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturer___Wholesaler.Repositories
{
    public class Users
    {
        private Database db = new Database(); // Ensure Database class exists

        public void AddUser(User user)
        {
            string query = $"INSERT INTO users (username, password, role) " +
                           $"VALUES ('{user.Username}', '{user.password}', '{user.role}')";

            db.ExecuteQuery(query);
        }
        public DataTable GetUsers()
        {
            return db.GetDataTable("SELECT * FROM users");
        }

        public void UpdateUser(User user)
        {
            string query = $"UPDATE users SET username='{user.Username}', password='{user.password}', " +
                           $"role='{user.role}',";

            db.ExecuteQuery(query);
        }
        public void DeleteUser(int id)
        {
            string query = $"DELETE FROM users WHERE id={id}";
            db.ExecuteQuery(query);
        }
    }
}
