using System.Collections.Generic;
using Travel.Data;
using Travel.DTO;

namespace Travel.Business
{
    public class AutoresBusiness
    {
        public List<Autore> Consultar()
        {
            return new AutoresData().Consultar();
        }
    }
}
