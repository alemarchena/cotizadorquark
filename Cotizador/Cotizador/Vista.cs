using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EspacioPresentador;

namespace Cotizaciones
{
    /// <summary>
    /// La clase Vista controla la lógica de los datos de la vista
    /// </summary>
    class Vista : IVista
    {
        Presentador _presentador;
        /// <summary>
        /// Variable que implementa la interfaz IVista
        /// </summary>
        IVista _iv;

        #region Variables de la vista
        string _nombre;
        string _apellido;
        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }


        private string _nombreTienda;
        private string _direccionTienda;
        public string NombreTienda { get => _nombreTienda; }
        public string DireccionTienda { get => _direccionTienda;}

        #endregion

        public Vista()
        {            
            _presentador = new Presentador();
            _iv = this;
        }

        #region Funciones del Vendedor
        /// <summary>
        /// Crea un vendedor con parámetros implícitos de nombre y apellido en caso de no recibir nada
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public string CrearVendedor(string nombre, string apellido)
        {
            _nombre = nombre   != "" ? nombre : "Usuario";
            _apellido = apellido != "" ? apellido : "Anónimo";

            return _iv.CrearVendedor(Nombre, Apellido);
        }

        string IVista.CrearVendedor(string nombre, string apellido)
        {
            return _presentador.CrearVendedor(nombre , apellido);
        }

        public string MostrarIdHistorialVendedor()
        {
            return _presentador.MostrarIdHistorialVendedor();
        }
        #endregion

        #region Funciones de la Tienda

        public void CrearTienda(string nombre, string direccion)
        {

            _nombreTienda = nombre != "" ? nombre : "Tienda anónima";
            _direccionTienda = direccion != "" ? direccion : "Dirección Desconocida";

            _presentador.CrearTienda(nombre, direccion);
        }
        #endregion

        #region Lista de precios con Stock

        public List<string> MostrarPrendas()
        {
            return _presentador.MostrarPrendas();
        }
        #endregion
    }
}
