using System;
using CAI_06VentaRepuestos.Dominio.Excepciones;

namespace CAI_06VentaRepuestos.Dominio
{
    public class Repuesto
    {
        #region Variables
        uint _codigo;       //Este tipo de valor me asegura que siempre debe ser positivo
        string _nombre;
        double _precio;
        uint _stock;        //Este tipo de valor me asegura que siempre debe ser positivo
        string _categoria;

        #endregion

        #region Propiedades
        public uint Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        #endregion

        #region Constructores
        public Repuesto(uint codigo, string nombre, double precio, uint stock, string categoria)
        {
            _codigo = codigo;
            _nombre = nombre;
            _stock = stock;
            Categoria(categoria);
            Precio(precio);
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return ("Soy un repuesto de la categoria: " + _categoria);
        }
        /// <summary>
        /// Devuelve el valor de la categoria de esta instancia
        /// </summary>
        /// <returns></returns>
        public string Categoria() { return _categoria; }
        /// <summary>
        /// Asigna el valor de la categoria a la instancia.
        /// Se verifica que el valor exista
        /// </summary>
        /// <param name="categoria"></param>
        public void Categoria(string categoria)
        {
            if (ValidarCategoria(categoria)) { _categoria = categoria; }
            else { throw new CategoriaInexistenteExcepcion(); }
        }
        public double Precio() { return _precio; }
        public void Precio(double precio)
        {
            if (precio >= 0) { _precio = precio; }
            else { throw new ElValorNoPuedeSerNegativoExcepcion(); }
        }
        public uint Stock() { return _stock; }
        public void AumentarStock(uint cantidad) { _stock += cantidad; }
        public void DisminuirStock(uint cantidad)
        {
            if ((_stock - cantidad) < 0) { throw new ImposibleQuitarEstaCantidadExcepcion(); }
            else { _stock -= cantidad; }
        }
        private bool ValidarCategoria(string categoria)
        {
            if (Enum.IsDefined(typeof(CategoriaEnum), categoria))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
