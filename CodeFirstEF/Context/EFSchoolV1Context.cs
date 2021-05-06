using CodeFirstEF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF.Context
{
    public class EFSchoolV1Context : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
    }
}
