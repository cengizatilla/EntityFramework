using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            EFSchoolContext context = new EFSchoolContext();
            List<Customer> dataItemList = context.Customers.ToList();
            for (int i = 0; i < dataItemList.Count; i++)
            {
                Console.WriteLine(dataItemList[i].FirstName + " " + dataItemList[i].LastName);
            }
            Console.ReadLine();
        }
    }
}
