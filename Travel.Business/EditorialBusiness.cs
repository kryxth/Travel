using System.Collections.Generic;
using Travel.Data;
using Travel.DTO;

namespace Travel.Business
{
    public class EditorialBusiness
    {
        public List<Editoriale> Consultar()
        {
            return new EditorialesData().Consultar();
        }
    }
}
