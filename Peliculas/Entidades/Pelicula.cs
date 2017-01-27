﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Peliculas.Entidades
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Estreno { get; set; }
        public string Descripcion { get; set; }
        public string CategoriaId { get; set; }
    }
}
