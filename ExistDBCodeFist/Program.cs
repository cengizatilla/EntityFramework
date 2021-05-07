using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistDBCodeFist
{
    class Program
    {
        static void Main(string[] args)
        {
            Context.Model dbModel = new Context.Model();
            var dataItemList = dbModel.Customer.ToList();
            Console.ReadLine();
        }
    }
}
