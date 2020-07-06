using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_Ap2_Nuñez.DAL
{
    public class Contexto : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= C:\Users\stive\OneDrive\Escritorio\BD\APO.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            


        }


    }
}
