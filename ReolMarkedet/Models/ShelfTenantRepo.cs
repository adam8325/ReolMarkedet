using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Models
{
    public class ShelfTenantRepo
    {
        private string _connectionString;
        public ShelfTenantRepo()
        {
            _connectionString = DataAccessHelper.CNNString("MyConnection");
              
        }
        public void AddShelfTenant()
        {

        }

        public List<ShelfTenant> GetShelfTenants()
        {
            List<ShelfTenant> shelfTenants = new List<ShelfTenant>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM [DB_F23_49].[dbo].[SHELFTENANT]";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            var shelfTenant = new ShelfTenant(Convert.ToInt32(reader["ShelfTenantId"]), reader["Name"].ToString(), reader["Email"].ToString(), reader["Phone"].ToString(), reader["AccountDetails"].ToString());

                            shelfTenants.Add(shelfTenant);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return shelfTenants;
        }

        public void UpdateShelfTenant()
        {

        }

        public void DeleteShelfTenant()
        {

        }
    }
}
