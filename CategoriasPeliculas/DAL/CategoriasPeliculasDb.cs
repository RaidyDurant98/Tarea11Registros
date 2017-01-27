using CategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CategoriasPeliculas.DAL
{
    public class CategoriasPeliculasDb : DbContext
    {
        public CategoriasPeliculasDb() : base("ConStr")
        {

        }

        public DbSet<Categorias> categorias { get; set; }
    }
}
