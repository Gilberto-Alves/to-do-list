using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Infrastruct
{
    public class ContextConnection : DbContext
    {
        public DbSet<Lista> Listas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}

//UseNpgsql("Host=localhost;Database=Lista;Username=postgres;Password=12345");