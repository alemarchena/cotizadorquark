using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizador;
using EspacioPresentador;

namespace Cotizaciones
{
    /// <summary>
    /// La clase Vista controla la lógica de los datos de la vista
    /// </summary>
    sealed class Vista : IVista
    {
        IVista _iv;
        Presentador _presentador;

        public Vista()
        {
            _iv = this;
            _iv.CrearPresentador();
        }

        /// <summary>
        /// Variable que implementa la interfaz IVista
        /// </summary>


        #region Variables de la vista
        string _nombre;
        string _apellido;
        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }


        private string _nombreTienda;
        private string _direccionTienda;
        public string NombreTienda { get => _nombreTienda; }
        public string DireccionTienda { get => _direccionTienda; }

        #endregion
      

        #region Funciones del Vendedor
        /// <summary>
        /// Crea un vendedor con parámetros implícitos de nombre y apellido en caso de no recibir nada
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public string CrearVendedor(string nombre, string apellido)
        {
            _nombre = nombre != "" ? nombre : "Usuario";
            _apellido = apellido != "" ? apellido : "Anónimo";

            return _iv.CrearVendedor(Nombre, Apellido);
        }

        string IVista.CrearVendedor(string nombre, string apellido)
        {
            return _presentador.CrearVendedor(nombre, apellido);
        }

        /// <summary>
        /// Recibe tipo datos del front y los valida.
        /// 
        /// Tipos de prenda : 1=Camisa. 2=Pantalón.
        /// Estilos : 1=Común,2=Chupín.
        /// Tipos de Manga : 1=Corta, 2=Larga. 
        /// Tipos de Cuello: 1=Común, 2=Mao.
        /// </summary>
        /// <param name="idvendedor"></param>
        /// <param name="tipoPrenda"></param>
        /// <param name="calidad"></param>
        /// <param name="cantidad"></param>
        /// <param name="preciobase"></param>
        /// <param name="estilo"></param>
        /// <param name="cuello"></param>
        /// <param name="manga"></param>
        public int Cotizar(ref int stockdisponible,ref float preciocalculado,ref float total, string idvendedor, int tipoPrenda, int
            calidad, int cantidad, float preciobase,int estilo, int cuello,int manga)
        {
            int _pudocotizar = -1;

            if(!ValidarCampos(idvendedor, tipoPrenda, calidad, cantidad, preciobase, estilo, cuello, manga))
            {
                switch (tipoPrenda)
                {
                    case 1:
                        _pudocotizar = _presentador.Cotizar(ref stockdisponible, ref preciocalculado, ref total, idvendedor, cantidad, preciobase, calidad, manga, cuello);
                        break;

                    case 2:
                        _pudocotizar = _presentador.Cotizar(ref stockdisponible, ref preciocalculado, ref total, idvendedor, cantidad, preciobase,calidad,estilo);
                        break;
                }


            }

            return _pudocotizar;
        }

        private bool ValidarCampos(string idvendedor, int tipoPrenda, int
            calidad, int cantidad, float precio, int estilo, int cuello, int manga)
        {
            bool _error = false;

            if (tipoPrenda < 1 || tipoPrenda > 2) 
            {_error = true; MessageBox.Show("El tipo de prenda puede valer 1 o 2");}

            if (idvendedor == "")
            {_error = true; MessageBox.Show("El id del vendedor debe contener un string"); }


            if (cantidad < 1 || cantidad > 1000)
            {_error = true; MessageBox.Show("La cantidad permitida es entre 0 y 1000"); }

            if (precio < 1 || precio > 1000000)
            {_error = true; MessageBox.Show("La precio debe ser un valor entre 0 y 1.000.000");}

            if (calidad < 1 || calidad > 2)
            {_error = true; MessageBox.Show("La calidad puede se un valor 1 o 2" );}

            if (estilo < 1 || estilo > 2)
            {_error = true; MessageBox.Show("El estilo puede se un valor 1 o 2" );}

            if (cuello < 1 || cuello > 2)
            {_error = true; MessageBox.Show("El cuello puede se un valor 1 o 2" );}

            if (manga < 1 || manga > 2)
            {_error = true; MessageBox.Show("La manga puede se un valor 1 o 2" );}

            return _error;

        }

        public string MostrarIdHistorialVendedor()
        {
            return _presentador.MostrarIdHistorialVendedor();
        }

        public List<string> MostrarHistorial()
        {
            return _presentador.MostrarHistorial();
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

        public void CrearPresentador()
        {
            _presentador = new Presentador();
        }


        #endregion
    }
}
