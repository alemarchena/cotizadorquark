using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    sealed class Historial
    {
        string _idhistorial;
        string _idvendedor;

        /// <summary>
        /// Lista de cotizaciones que tiene un historial
        /// </summary>
        List<ItemCotizacion> _cotizaciones;

        /// <summary>
        /// Constructor del historial del vendedor
        /// </summary>
        /// <param name="idvendedor"></param>
        public Historial(string idvendedor)
        {
            _idvendedor = idvendedor;
            _cotizaciones = new List<ItemCotizacion>();
            NuevoHistorial();
        }

        private void NuevoHistorial(){_idhistorial = Utiles.GenerarTextoAleatorio(5);}
        
        /// <summary>
        /// La propiedad Idhistorial es creada automáticamente cuando se genera un nuevo historial
        /// </summary>
        public string Idhistorial { get => _idhistorial; }
        
        internal List<ItemCotizacion> Cotizaciones { get => _cotizaciones; }

        public void CrearCotizacion(string idvendedor, Prenda prenda, int cantidad, float preciobase, float preciocalculado, float total)
        {
            _cotizaciones.Add(new ItemCotizacion(idvendedor, prenda, cantidad, preciobase, preciocalculado, total));
        }
    }
}
