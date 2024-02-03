using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Microsoft.Extensions.Logging;

namespace Database.Context
{
    public class PasswordManagerDBContext : DbContext
    {
        public PasswordManagerDBContext(DbContextOptions<PasswordManagerDBContext> contextOptions) : base(contextOptions)
        {

        }

        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //To Display the Generated the Database Script
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            
            optionsBuilder.EnableDetailedErrors();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PasswordManager_DB");
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<PasswordOptions> PasswordOptions { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }

    }
}
