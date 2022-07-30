using System;
using System.Collections.Generic;
using Travel.Data;
using Travel.DTO;

namespace Travel.Business
{
    public class LibroBusiness
    {
        public List<Libro> Consultar()
        {
            return new LibroData().Consultar();
        }

        public bool Guardar(Libro libro)
        {
            return new LibroData().Guardar(libro);
        }

        public bool Actualizar(Libro libro)
        {
            return new LibroData().Actualizar(libro);
        }

        public bool Eliminar(int id)
        {
            return new LibroData().Eliminar(id);
        }
    }
}
