using System;
using Microsoft.EntityFrameworkCore;
using WDC.Orders.Data.Entities;

namespace WDC.Orders.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }

    }
}

