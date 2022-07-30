using System;

namespace Travel.Utilities
{
    public static class Error
    {
        public static string ManejoError(Exception ex)
        {
            //Guardar log
            if (ex.GetType() == typeof(ExcepcionControlada))            
                return ex.Message;
            else
                return "Ha ocurrido un error inesperado";
        }
    }
}
