using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class AppDbContext : DbContext
    {
        // Database configure
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Smarty\source\repos\Project1\WpfApp1\Database1.mdf;Integrated Security=True");
        }
        public DbSet<Invoice> Print { get; set; } 
        public DbSet<Records> Table { get; set; }
    }
}
