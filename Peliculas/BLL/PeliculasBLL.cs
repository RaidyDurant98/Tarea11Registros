using Peliculas.DAL;
using Peliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Peliculas.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Pelicula peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new PeliculasDb())
            {
                try
                {
                    conec.peliculas.Add(peliculaNueva);
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            return interruptor;
        }

        public static Pelicula Buscar(int idPelicula)
        {
            var pelicula = new Pelicula();

            using(var conec = new PeliculasDb())
            {
                try
                {
                    pelicula = conec.peliculas.Find(idPelicula);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return pelicula;
        }

        public static bool Eliminar(Pelicula peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new PeliculasDb())
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
