using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using EF_Example.Models;

namespace EF_Example.Repository
{
    public class UserContext : DbContext 
    {
        public DbSet<User> Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=EFExample.db");
    }
}
