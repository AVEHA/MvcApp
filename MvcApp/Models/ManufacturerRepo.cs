using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace MvcApp.Models
{
    public class ManufacturerRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                manufacturers = db.Query<Manufacturer>("SELECT * FROM Manufacturer").ToList();
            }
            return manufacturers;
        }

        public Manufacturer Create(Manufacturer manufacturer)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO Manufacturer (Name, Description) VALUES(@Name, @Description); SELECT CAST(SCOPE_IDENTITY() as int)";
                int manufacturerId = db.Query<int>(sqlQuery, manufacturer).FirstOrDefault();
                manufacturer.Id = manufacturerId;
            }
            return manufacturer;
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Manufacturer WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}