using Entity4.AreaEntityContext;
using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get;set;}

        public DbSet<Country> Countrys { get; set; }

        public DbSet<Groups> Groups { get; set; }

        public DbSet<Pol> Pols { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Theme> Themes { get; set; }
        
        public DbSet<Message> Messages { get; set; }

        public DbSet<AddresSent> AddresSents { get; set; }

        public ApplicationContext()
        {
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DbEntity4;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurationOption());
            modelBuilder.ApplyConfiguration(new CountryConfigurationOption());
            modelBuilder.ApplyConfiguration(new GroupsConfigurationOption());
            modelBuilder.ApplyConfiguration(new PolConfigurationOption());
            modelBuilder.ApplyConfiguration(new ProfileConfigurationOption());
            modelBuilder.ApplyConfiguration(new RoleConfigurationOption());
            modelBuilder.ApplyConfiguration(new ThemeConfigurationOption());
            modelBuilder.ApplyConfiguration(new MessageConfigurationOption());
            modelBuilder.ApplyConfiguration(new AddresSentConfigurationOption());

        }
    }
}
