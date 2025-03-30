using Manufacturer___Wholesaler.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Manufacturer___Wholesaler.Repositories;

namespace Manufacturer___Wholesaler.Repositories
{
    public class RawMaterials
    {
        private Database db = new Database(); // Ensure Database class exists

        public void AddRawMaterial(RawMaterial material)
        {
            string query = $"INSERT INTO raw_materials (name, supplier, quantity, unit, cost, delivery_date) " +
                           $"VALUES ('{material.Name}', '{material.Supplier}', {material.Quantity}, '{material.Unit}', {material.Cost}, '{material.DeliveryDate}')";

            db.ExecuteQuery(query);
        }

        public DataTable GetRawMaterials()
        {
            return db.GetDataTable("SELECT * FROM raw_materials");
        }

        public void UpdateRawMaterial(RawMaterial material)
        {
            string query = $"UPDATE raw_materials SET name='{material.Name}', supplier='{material.Supplier}', " +
                           $"quantity={material.Quantity}, unit='{material.Unit}', cost={material.Cost}, " +
                           $"delivery_date='{material.DeliveryDate}' WHERE id={material.Id}";

            db.ExecuteQuery(query);
        }

        public void DeleteRawMaterial(int id)
        {
            string query = $"DELETE FROM raw_materials WHERE id={id}";
            db.ExecuteQuery(query);
        }

    }
}
