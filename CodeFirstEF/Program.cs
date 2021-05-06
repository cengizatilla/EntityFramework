using CodeFirstEF.Entities;
using CodeFirstEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CustomerRepository customerRepo = new CustomerRepository();
            List<Customer> dataItemList = customerRepo.GetAllData();
            for (int i = 0; i < dataItemList.Count; i++)
            {
                Console.WriteLine($"{dataItemList[i].FirstName} {dataItemList[i].LastName}");
            }
            Console.ReadLine();
        }
    }
}
