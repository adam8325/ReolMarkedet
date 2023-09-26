using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Models
{
    public class ItemRepo
    {
        private string _connectionString;
        public ItemRepo()
        {
            _connectionString = DataAccessHelper.CNNString("MyConnection");

        }
        public void AddItem()
        {

        }

        public List<Item> GetItemsForTenant(int tenantId)
        {
            List<Item> shelfTenants = new List<Item>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = $"SELECT *   FROM [DB_F23_49].[dbo].[ITEM] where ShelfTenantId = {tenantId}";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            var item = new Item(reader["Description"].ToString(), Convert.ToInt32(reader["Barcode"]), Convert.ToDouble(reader["Price"]));
                            shelfTenants.Add(item);
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

        public void UpdateItem()
        {

        }

        public void DeleteItem()
        {

        }
    }
}
