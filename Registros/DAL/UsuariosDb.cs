using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros.DAL
{
    public class UsuariosDb : DbContext
    {
        public UsuariosDb() : base("ConStr")
        {

        }

        public DbSet<Usuarios> usuario { get; set; }
    }
}
