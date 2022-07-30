using System;
using System.Collections.Generic;

#nullable disable

namespace Travel.DTO
{
    public partial class Libro
    {
        public Libro()
        {
            AutoresLibros = new HashSet<AutoresLibro>();
        }

        public int Isbn { get; set; }
        public int Editoriales { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }

        public virtual Editoriale EditorialesNavigation { get; set; }
        public virtual ICollection<AutoresLibro> AutoresLibros { get; set; }
    }
}
