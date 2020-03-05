using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.Models.DataBase
{
    public class HappyPetsContext:DbContext
    {

        public HappyPetsContext(DbContextOptions<HappyPetsContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=happayts;user=root;password=");
        }

        public DbSet<People> People { get; set; }
        public DbSet<Pet> Pet { get; set; }
    }
}
