using System.Collections.Generic;
using System.Linq;
using Travel.DTO;

namespace Travel.Data
{
    public class AutoresData
    {
        public List<Autore> Consultar()
        {
            using (var context = new TravelContext())
            {
                return context.Autores.ToList();
            }
        }
    }
}
