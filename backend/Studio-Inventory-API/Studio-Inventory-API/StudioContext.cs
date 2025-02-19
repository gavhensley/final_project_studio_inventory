﻿using Microsoft.EntityFrameworkCore;
using Studio_Inventory_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Studio_Inventory_API
{

    public class StudioContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Equipment> EquipmentList { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rental { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=StudioDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                            .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Microphone"
                }
                );
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment()
                {
                    Id = 1,
                    SerialNumber = "123",
                    Name = "SM57",
                    Description = "Good all around microphone.",
                    Image = "https://media.sweetwater.com/api/i/b-original__w-300__h-300__bg-ffffff__q-85__ha-dde2192b5ddfa7d1__hmac-b5b5985e3aa2e68b005b31f94060a683b2ccf4fc/images/items/350/SM57.jpg",
                    CategoryId = 1,
                    RentalDates = "2021-04-20"
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Jeff",
                    IsAdmin = false,
                    Password = "123"
                }
                );
            modelBuilder.Entity<Rental>().HasData(
                new Models.Rental()
                {
                    RentalDate = "2021-04-20",
                    Id = 1,
                    IsApproved = false,
                    IsDenied = false,
                    FeedBack = "seeded feedback",
                    UserId = 1,
                    EquipmentIds = "1"
                });
        }

    }
}
