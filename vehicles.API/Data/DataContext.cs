﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicles.API.Data.Entities;

namespace vehicles.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<VehicleType> vehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
