using Peliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Peliculas.DAL
{
    public class PeliculasDb : DbContext
    {
        public PeliculasDb() : base("ConStr")
        {

        }

        public DbSet<Pelicula> peliculas { get; set; }
    }
}
