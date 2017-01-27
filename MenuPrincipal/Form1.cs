using CategoriasPeliculas;
using Peliculas;
using Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Usuariosbutton_Click(object sender, EventArgs e)
        {
            UsuariosForm formulario = new UsuariosForm();
            formulario.Show();
        }

        private void Categoriasbutton_Click(object sender, EventArgs e)
        {
            CategoriasPeliculasForm formulario = new CategoriasPeliculasForm();
            formulario.Show();
        }

        private void Peliculasbutton_Click(object sender, EventArgs e)
        {
            PeliculasForm formulario = new PeliculasForm();
            formulario.Show();
        }
    }
}
