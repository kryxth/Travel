using System;

namespace Travel.Utilities
{
    public class ExcepcionControlada : Exception
    {
        public ExcepcionControlada(string message) : base(message)
        {
        }
    }
}
