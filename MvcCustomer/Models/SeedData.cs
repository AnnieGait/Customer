using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcCustomer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCustomerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCustomerContext>>()))
            {
                // Look for any customers.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        FirstName = "Rick",
                        LastName = "Sanchez",
                        Phone = "(+99) 0123-456-789",
                        Address = "Terra Street 12",
                        Email = "rickSanchez@gmail.com"

                    },

                    new Customer
                    {
                        FirstName = "Morty",
                        LastName = "Smith",
                        Phone = "0123-131-113",
                        Address = "Terra Street 12",
                        Email = "morty_n_jessica@gmail.com"
                    },

                    new Customer
                    {
                        FirstName = "Michael",
                        LastName = "Scott",
                        Phone = "(+80) 0969-456-456",
                        Address = "Dunder Mifflin Street 1",
                        Email = "prisonMike@gmail.com"
                    },

                    new Customer
                    {
                        FirstName = "Μιράντα",
                        LastName = "Παπαδοπούλου",
                        Phone = "(+30) 2310 200 203",
                        Address = "Εγνατία 56",
                        Email = "mariaPapadopouloy@yahooo.gr"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}