using System;
using System.Collections.Generic;
using System.Text;
using CarStockingg.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarStockingg.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //creating the reference to my table
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Stock> Stocks { get; set; }
    }
}