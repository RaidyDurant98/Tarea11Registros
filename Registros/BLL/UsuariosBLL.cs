using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuarioNuevo)
        {
            bool interruptor = false;

            using(var conec = new UsuariosDb())
            {
                try
                {
                    conec.usuario.Add(usuarioNuevo);
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

        public static Usuarios Buscar(int id)
        {
            var usuario = new Usuarios();

            using(var conec = new UsuariosDb())
            {
                try
                {
                    usuario = conec.usuario.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return usuario;
        }

        public static bool Eliminar(Usuarios usuario)
        {
            bool interruptor = false;

            using(var conec = new UsuariosDb())
            {
                try
                {
                    conec.Entry(usuario).State = EntityState.Deleted;
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
