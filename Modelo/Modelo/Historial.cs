using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    class Historial
    {
        string _idhistorial;
        string _idvendedor;

        /// <summary>
        /// Lista de cotizaciones que tiene un historial
        /// </summary>
        List<Cotizacion> _cotizaciones;
        /// <summary>
        /// Constructor del historial del vendedor
        /// </summary>
        /// <param name="idvendedor"></param>
        public Historial(string idvendedor)
        {
            _idvendedor = idvendedor;
            _cotizaciones = new List<Cotizacion>();
            NuevoHistorial();
        }

        private void NuevoHistorial(){_idhistorial += 1;}
        /// <summary>
        /// La propiedad Idhistorial es creada automáticamente cuando se genera un nuevo historial
        /// </summary>
        public string Idhistorial { get => _idhistorial; }
        internal List<Cotizacion> Cotizaciones { get => _cotizaciones; }
    }
}
