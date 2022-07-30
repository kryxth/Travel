using System;
using System.Collections.Generic;
using System.Linq;
using Travel.DTO;

namespace Travel.Data
{
    public class EditorialesData
    {
        public List<Editoriale> Consultar()
        {
            using (var context = new TravelContext())
            {
                return context.Editoriales.ToList();
            }
        }
    }
}
