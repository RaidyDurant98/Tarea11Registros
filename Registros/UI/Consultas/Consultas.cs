using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.UI.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuarioLista = new List<Usuarios>();
            var usDb = new UsuariosDb();

            usuarioLista = usDb.usuario.ToList();
            ConsultaUsuariodataGridView.DataSource = usuarioLista;
        }
    }
}
