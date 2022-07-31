using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Travel.DTO;
using Travel.Utilities;

namespace Travel.Data
{
    public class LibroData
    {
        public List<Libro> Consultar()
        {
            using (var context = new TravelContext())
            {
                return context.Libros.Include("Editoriales").ToList();
            }
        }

        public Libro ConsultarPorId(int id)
        {
            using (var context = new TravelContext())
            {
                Libro libro = context.Libros.Find(id);
                return libro;
            }
        }

        public bool Guardar(Libro libro)
        {
            using (var context = new TravelContext())
            {
                context.Libros.Add(libro);
                context.SaveChanges();
            }
            return true;
        }

        public bool Actualizar(Libro libro)
        {
            using (var context = new TravelContext())
            {
                context.Update(libro);
                context.SaveChanges();
            }
            return true;
        }

        public bool Eliminar(int id)
        {
            using (var context = new TravelContext())
            {
                Libro libro =  context.Libros.Find(id);

                if (libro == null)
                    throw new ExcepcionControlada("Libro no encontrado");

                context.Libros.Remove(libro);
                context.SaveChanges();
            }
            return true;
        }
    }
}
