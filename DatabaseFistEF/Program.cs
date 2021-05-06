using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFistEF
{
    class Program
    {
        static void Main(string[] args)
        {
            EFSchoolEntities eFSchoolEntities = new EFSchoolEntities();
            List<Customer> dataItemList = eFSchoolEntities.Customers.ToList();
            for (int i = 0; i < dataItemList.Count; i++)
            {
                Console.WriteLine($"{dataItemList[i].FirstName} {dataItemList[i].LastName}");
            }
        }
    }
}
