﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Travel.DTO
{
    public partial class Autore
    {
        public Autore()
        {
            AutoresLibros = new HashSet<AutoresLibro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public virtual ICollection<AutoresLibro> AutoresLibros { get; set; }
    }
}
