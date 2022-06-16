using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplatePraktika.Models;

namespace TemplatePraktika.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutCard> AboutCards { get; set; }
    }
}
