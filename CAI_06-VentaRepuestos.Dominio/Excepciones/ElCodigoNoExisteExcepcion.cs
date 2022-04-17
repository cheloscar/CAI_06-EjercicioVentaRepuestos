using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class ElCodigoNoExisteExcepcion : Exception
    {
        public ElCodigoNoExisteExcepcion() : base ("El código ingresado no existe en la lista de productos.")
        {
        }
    }
}
