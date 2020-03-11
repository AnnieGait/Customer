using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCustomer.Models; // Enables public DbSet<Movie> Movie

// see "Add a model" section from tutorial
// namespace might need to be changed from "MvcCustomer.Models" to "MvcCustomer.Data"
namespace MvcCustomer.Models
{
    public class MvcCustomerContext : DbContext
    {
        public MvcCustomerContext (DbContextOptions<MvcCustomerContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCustomer.Models.Customer> Customer { get; set; }
    }
}
