using System;
using System.Collections.Generic;
using CAI_06VentaRepuestos.Dominio.Excepciones;

namespace CAI_06VentaRepuestos.Dominio
{
    public class VentaRepuestos
    {
        #region Variables
        List<Repuesto> _listaProductos = new List<Repuesto>();
        string _nombreComercio;
        string _direccion;

        #endregion

        #region Propiedades
        public string NombreComercio { get => _nombreComercio; set => _nombreComercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        #endregion

        #region Constructores
        public VentaRepuestos(string nombreComercio, string direccion)
        {
            _nombreComercio = nombreComercio;
            _direccion = direccion;
        }

        #endregion

        #region Métodos
        public void AgregarRepuesto(Repuesto repuesto)
        {
            _listaProductos.Add(repuesto);
        }
        /// <summary>
        /// Se quita de la lista el repuesto que tenga el código indicado
        /// </summary>
        /// <param name="codigo">Código del repuesto que se quiere quitar</param>
        public void QuitarRepuesto(uint codigo)
        {
            Repuesto _tempRepuesto;
            _tempRepuesto = _listaProductos[EncontrarIndice(codigo)];
            if (_tempRepuesto.Stock() == 0) { _listaProductos.Remove(_tempRepuesto); }
            else { throw new ImposibleEliminarRepuestoExcepcion(); }
        }
        public void ModificarPrecio(uint codigo, double precio)
        {
            if (precio >= 0)
            {
                _listaProductos[EncontrarIndice(codigo)].Precio(precio);
            }
            else { throw new ElValorNoPuedeSerNegativoExcepcion(); }
        }
        public void AgregarStock(uint codigo, uint cantidad)
        {
            _listaProductos[EncontrarIndice(codigo)].AumentarStock(cantidad);
        }
        public void QuitarStock(uint codigo, uint cantidad)
        {
            _listaProductos[EncontrarIndice(codigo)].DisminuirStock(cantidad);
        }
        public List<Repuesto> TraerPorCategoria(int categoria)
        {
            bool _coincidencias = false;
            List<Repuesto> _tempProductos = new List<Repuesto>();
            foreach(Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Categoria() == Enum.GetName(typeof(CategoriaEnum), categoria))
                {
                    _coincidencias = true;
                    _tempProductos.Add(repuesto);
                }
            }
            if (_coincidencias) { return _tempProductos; }
            else { throw new NoHuboCoincidenciasExcepcion(); }
        }
        /// <summary>
        /// Este método devuelve el indice del producto que se quiere operar
        /// </summary>
        /// <param name="codigo">Codigo interno del producto que se quiere operar</param>
        /// <returns></returns>
        private int EncontrarIndice(uint codigo)
        {
            int _tempInt;
            _tempInt = _listaProductos.FindIndex(repuesto => repuesto.Codigo == codigo);
            return _tempInt;
        }
        #endregion
    }
}
