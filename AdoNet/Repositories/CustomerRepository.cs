using AdoNet.Database;
using AdoNet.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetDataList()
        {
            List<Customer> dataItemList = new List<Customer>();

            DatabaseLogicLayer databaseLogicLayer = new DatabaseLogicLayer();

            SqlCommand command = new SqlCommand("Select * from Customer");

            SqlDataReader reader = databaseLogicLayer.GetDataList(command);
            while (reader.Read())
            {
                dataItemList.Add(new Customer()
                {
                    CustomerId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    LastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                });
            }
            reader.Close();
            databaseLogicLayer.ConnectionWizard();
            return dataItemList;
        }

    }
}
