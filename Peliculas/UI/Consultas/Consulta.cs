using Peliculas.DAL;
using Peliculas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Peliculas.UI.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void VerListabutton_Click(object sender, EventArgs e)
        {
            List<Pelicula> peliculaLista = new List<Pelicula>();
            var peliDb = new PeliculasDb();

            peliculaLista = peliDb.peliculas.ToList();
            VerListadataGridView.DataSource = peliculaLista;
        }
    }
}
