using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class ImposibleEliminarRepuestoExcepcion : Exception
    {
        public ImposibleEliminarRepuestoExcepcion() : base ("No se puede eliminar un respuesto mientras tenga stock.")
        {
        }
    }
}
