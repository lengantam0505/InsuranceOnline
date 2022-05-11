using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceOnline.Models
{
    public class InsuranceDBContext : DbContext
    {
        public DbSet<Adminstrator> Adminstrators { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Category> Categories { set; get; }

        public InsuranceDBContext( DbContextOptions options) : base(options)
        {
            
        }
    }

}
