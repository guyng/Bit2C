using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Domain;
using DAL.Enum;
using Microsoft.AspNetCore.Identity;

namespace Bit2C.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<IdentityUser>
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    Amount = new Random().Next(1,100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.BUY,
                    OrderDate = DateTime.Now
                },
                new Order()
                {
                    Id = 2,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.BUY,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 3,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.BUY,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 4,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.BUY,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 5,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.SELL,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 6,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.SELL,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 7,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.SELL,
                    OrderDate = DateTime.Now

                },
                new Order()
                {
                    Id = 8,
                    Amount = new Random().Next(1, 100),
                    Price = new Random().Next(1, 1000),
                    OrderType = OrderType.SELL,
                    OrderDate = DateTime.Now

                }
            );
        }
    }
}
