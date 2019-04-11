using Microsoft.EntityFrameworkCore;
using RazorRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorRestaurant.Data
{
    public class RazorRestaurantDbContext : DbContext
    {
        public RazorRestaurantDbContext(DbContextOptions<RazorRestaurantDbContext> options)
            :base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
