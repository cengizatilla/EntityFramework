using AdoNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Repositories.CustomerRepository customerRepository = new Repositories.CustomerRepository();
            List<Customer> dataItemList = customerRepository.GetDataList();
            for (int i = 0; i < dataItemList.Count; i++)
            {
                Console.WriteLine(dataItemList[i]);
            }
        }
    }
}
