using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Business;
using Travel.DTO;

namespace Travel.Web.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            List<Libro> libros = new LibroBusiness().Consultar();
            return View(libros);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Libro libro = new LibroBusiness().ConsultarPorId(id.Value);
            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Isbn,Editoriales,Titulo,Sinopsis,NPaginas")] Libro libro)
        {
            if (id != libro.Isbn)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (libro.Isbn == 0)
                        new LibroBusiness().Guardar(libro);
                    else
                        new LibroBusiness().Actualizar(libro);
                }
                catch (Exception ex)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            List<Editoriale> editoriales = new EditorialBusiness().Consultar();
            ViewData["Editoriales"] = new SelectList(editoriales, "Id", "Nombre", libro.Editoriales);
            return View(libro);
        }
    }
}
        