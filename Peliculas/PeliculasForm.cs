using Peliculas.Entidades;
using Peliculas.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class PeliculasForm : Form
    {
        public PeliculasForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.PeliculasBLL.Buscar(Convert.ToInt32(PeliculaIdtextBox.Text));

            if (pelicula != null)
            {
                EstrenomaskedTextBox.Text = pelicula.Estreno;
                DescripciontextBox.Text = pelicula.Descripcion;
                CategoriaIdtextBox.Text = pelicula.CategoriaId;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = new Pelicula();

            pelicula.Estreno = EstrenomaskedTextBox.Text;
            pelicula.Descripcion = DescripciontextBox.Text;
            pelicula.CategoriaId = CategoriaIdtextBox.Text;

            if (pelicula != null)
            {
                BLL.PeliculasBLL.Guardar(pelicula);
                MessageBox.Show("La pelicula se a guardado...");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.PeliculasBLL.Buscar(Convert.ToInt32(PeliculaIdtextBox.Text));

            if (pelicula != null)
            {
                BLL.PeliculasBLL.Eliminar(pelicula);
                MessageBox.Show("Se a eliminado la pelicula...");
                Limpiar();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            PeliculaIdtextBox.Clear();
            EstrenomaskedTextBox.Clear();
            DescripciontextBox.Clear();
            CategoriaIdtextBox.Clear();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }
    }
}
