using CategoriasPeliculas.Entidades;
using CategoriasPeliculas.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CategoriasPeliculas
{
    public partial class CategoriasPeliculasForm : Form
    {
        public CategoriasPeliculasForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.CategoriasUsuariosBLL.Buscar(Convert.ToInt32(CategoriaIdtextBox.Text));

            if (pelicula != null)
            {
                DescripciontextBox.Text = pelicula.Descripcion;
            }
            else
            {
                MessageBox.Show("No existe categoria con ese codigo...");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = new Categorias();

            pelicula.Descripcion = DescripciontextBox.Text;

            if (pelicula != null)
            {
                BLL.CategoriasUsuariosBLL.Guardar(pelicula);
                MessageBox.Show("Categoria guardada...");
            }

        }

        private void Eliminarbutton2_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.CategoriasUsuariosBLL.Buscar(Convert.ToInt32(CategoriaIdtextBox.Text));

            if (pelicula != null)
            {
                BLL.CategoriasUsuariosBLL.Eliminar(pelicula);
                MessageBox.Show("Se elimino la categoria...");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria...");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Consultas c = new Consultas();
            c.Show();
        }

        private void CategoriasPeliculasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
