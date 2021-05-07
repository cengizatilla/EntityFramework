using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Context.Model dbContext = new Context.Model();
            var dataItemList = dbContext.Customer.ToList();
            for (int i = 0; i < dataItemList.Count; i++)
            {
                Console.WriteLine($"{dataItemList[i].FirstName} {dataItemList[i].LastName}");

            }
            Console.ReadLine();
        }
    }
}
