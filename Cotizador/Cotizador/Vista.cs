using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacioPresentador;

namespace Cotizaciones
{
    class Vista : IVista
    {
        Presentador _presentador;
        /// <summary>
        /// Variable que implementa la vista
        /// </summary>
        IVista _iv;

        public Vista()
        {            
            _presentador = new Presentador();
            _iv = this;
        }

        /// <summary>
        /// Crea un vendedor con parámetros implícitos de nombre y apellido en caso de no recibir nada
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public string CrearVendedor(string nombre = "User", string apellido = "Anonimo")
        {            
            return _iv.CrearVendedor(nombre, apellido);
        }

        string IVista.CrearVendedor(string nombre, string apellido)
        {
            return _presentador.CrearVendedor(nombre , apellido);
        }
    }
}
