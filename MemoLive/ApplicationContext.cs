using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MemoLive.db_service;

namespace MemoLive
{
public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString.cString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("MemoLive");
        }
    }
}
