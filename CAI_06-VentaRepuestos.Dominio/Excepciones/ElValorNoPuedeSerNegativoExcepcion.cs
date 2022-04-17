using System;
namespace CAI_06VentaRepuestos.Dominio.Excepciones
{
    public class ElValorNoPuedeSerNegativoExcepcion : Exception
    {
        public ElValorNoPuedeSerNegativoExcepcion() : base ("Esta propiedad no puede tomar un valor negativo.")
        {
        }
    }
}
