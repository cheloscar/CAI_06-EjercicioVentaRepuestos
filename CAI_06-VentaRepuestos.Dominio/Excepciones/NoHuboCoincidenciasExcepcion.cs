using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class NoHuboCoincidenciasExcepcion : Exception
    {
        public NoHuboCoincidenciasExcepcion() : base ("La búsqueda no ha encontrado coincidencias.")
        {
        }
    }
}
