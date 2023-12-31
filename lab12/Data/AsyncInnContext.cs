﻿using lab12.Models;
using Microsoft.EntityFrameworkCore;

namespace lab12.Data
{
    public class AsyncInnContext :DbContext
    {
        public AsyncInnContext(DbContextOptions options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasNoKey();
            modelBuilder.Entity<RoomAmenities>().HasNoKey();
            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel() { Id = 1, Name = "Royal", StreetAddress = "5th.Circle", City = "Amman", State = "Zahran", Country = "JOR", Phone = "079****" },
                    new Hotel() { Id = 2, Name = "4Seasons", StreetAddress = "5th.Circle", City = "Amman", State = "KFC", Country = "JOR", Phone = "079****" },
                    new Hotel() { Id = 3, Name = "Reds Carlton", StreetAddress = "5th.Circle", City = "Amman", State = "SHEC", Country = "JOR", Phone = "077****" }
    );
            modelBuilder.Entity<Room>().HasData(
              new Room() { ID = 1, Name = "honey", Layout = 1 },
              new Room() { ID = 2, Name = "red", Layout = 2 },
              new Room() { ID = 3, Name = "white", Layout = 3 }
              );
            modelBuilder.Entity<Amenities>().HasData(
              new Amenities() { Id = 1, Name = "AC" },
              new Amenities() { Id = 2, Name = "coffeeBar" },
              new Amenities() { Id = 3, Name = "Fridge" }
              );

            // Other configurations... 
        }
        public DbSet <Hotel> hotels { get; set; }
        public DbSet <Room> rooms { get; set; }
        public DbSet <HotelRoom> hotel_rooms { get; set;}
        public DbSet <RoomAmenities> room_amenities { get; set; }
        public DbSet <Amenities> amenities { get; set; }
    }
}
