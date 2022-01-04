using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<PortFolio> PortFolios { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Sosial> Sosials { get; set; }

    }
}
