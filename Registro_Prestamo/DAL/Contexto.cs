using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Prestamo.Models;

namespace Registro_Prestamo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\luisd\OneDrive\Escritorio\Universidad\Programacion Aplicada 2\Base_de_Datos_de_Blazor\PrestamosDB\Prestamos.db");
        }
    }
}
