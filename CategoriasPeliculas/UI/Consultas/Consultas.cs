using CategoriasPeliculas.DAL;
using CategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CategoriasPeliculas.UI.Consultas
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            List<Categorias> categorias = new List<Categorias>();
            var catDb = new CategoriasPeliculasDb();

            categorias = catDb.categorias.ToList();
            ListaCategoriasdataGridView.DataSource = categorias;
        }
    }
}
