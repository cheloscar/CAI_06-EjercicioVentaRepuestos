using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class ImposibleQuitarEstaCantidadExcepcion : Exception
    {
        public ImposibleQuitarEstaCantidadExcepcion() : base ("No se pueden quitar más elementos de los existentes.")
        {
        }
    }
}
