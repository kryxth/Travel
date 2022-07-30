using System;
using System.Collections.Generic;

#nullable disable

namespace Travel.DTO
{
    public partial class AutoresLibro
    {
        public int AutoresId { get; set; }
        public int LibrosIsbn { get; set; }

        public virtual Autore Autores { get; set; }
        public virtual Libro LibrosIsbnNavigation { get; set; }
    }
}
