using CodeFirstEF.Context;
using CodeFirstEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAllData()
        {
            EFSchoolV1Context context = new EFSchoolV1Context();
            return context.Customer.ToList();
        }
    }
}
