using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Test1.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }
        public DbSet<Customer> Customers { get; set; }

    }
        public class Customer
        {
            public int CustomerId { get; set; }
            [Column(TypeName = "nvarchar(200)")]

            public string First_Name { get; set; }
            [Column(TypeName = "nvarchar(200)")]

            public string Last_Name { get; set; }
            [Column(TypeName = "int")]

            public int Age { get; set; }
            [Column(TypeName = "nvarchar(250)")]

            public int Email { get; set; }
        }
   
}
