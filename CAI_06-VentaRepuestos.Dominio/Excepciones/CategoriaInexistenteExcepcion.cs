using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class CategoriaInexistenteExcepcion : Exception
    {
        public CategoriaInexistenteExcepcion() : base ("La categoria ingresada no existe.")
        {
        }
    }
}
