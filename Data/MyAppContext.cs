using System;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{

    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemClient>().HasKey(ic => new  
            {
                ic.ItemId,
                ic.ClientId
            });

            modelBuilder.Entity<ItemClient>().HasOne(ic => ic.Item).WithMany(i => i.ItemClients).HasForeignKey(ic => ic.ItemId);
            modelBuilder.Entity<ItemClient>().HasOne(ic => ic.Client).WithMany(ic => ic.ItemClients).HasForeignKey(c => c.ClientId);
            
            modelBuilder.Entity<SerialNumber>().HasData(
                new SerialNumber { Id = 10, Name = "Mic150", ItemId = 5 }
            ); 
            
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 5, Name = "Microphone", Price = 75, SerialNumberId = 10 }
            ); 

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" }
            ); 
            
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ItemClient> ItemClients { get; set; }
    }
}