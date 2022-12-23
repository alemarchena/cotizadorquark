using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    sealed public class Historial
    {
        private string _idhistorial;
        private string _idvendedor;

        /// <summary>
        /// Lista de cotizaciones que tiene un historial
        /// </summary>
        private List<ItemCotizacion> _cotizaciones;

        public string Idhistorial { get => _idhistorial; }
        public List<ItemCotizacion> Cotizaciones { get => _cotizaciones; }

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
        

        public void CrearCotizacion(string idvendedor, Prenda prenda, ECPT ecpt)
        {
            Cotizaciones.Add(new ItemCotizacion(idvendedor, prenda, ecpt));
        }
    }
}
