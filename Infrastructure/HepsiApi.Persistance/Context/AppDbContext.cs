using HepsiApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistance.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(){ }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        // ef core tablo ilişkilerini otomatik olarak belirliyor. bunu da entityler üzerinde yaptıgımız ilişkilerden çıkartıyor.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
