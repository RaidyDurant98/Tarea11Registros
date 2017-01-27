using CategoriasPeliculas.DAL;
using CategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CategoriasPeliculas.BLL
{
    public class CategoriasUsuariosBLL
    {
        public static bool Guardar(Categorias peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new CategoriasPeliculasDb())
            {
                try
                {
                    conec.categorias.Add(peliculaNueva);
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }
        public static Categorias Buscar(int idPelicula)
        {
            var pelicula = new Categorias();

            using(var conec = new CategoriasPeliculasDb())
            {
                try
                {
                    pelicula = conec.categorias.Find(idPelicula);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return pelicula;
        }
        public static bool Eliminar(Categorias peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new CategoriasPeliculasDb())
            {
                try
                {
                    conec.Entry(peliculaNueva).State = EntityState.Deleted;
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }
    }
}
