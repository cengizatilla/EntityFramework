using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class Model:DbContext
    {
        public DbSet<Customer> Customer { get; set; }
    }
}
