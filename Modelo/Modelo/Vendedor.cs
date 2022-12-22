using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    sealed public class Vendedor
    {
        string  _idvendedor;
        string  _nombre;
        string  _apellido;
        Historial historial;
        public struct preciostock
        {
            public float _precio;
            public int _stock;
        }
        /// <summary>
        /// La propiedad Idvendedor se genera automáticamente cuando es creado el vendedor
        /// </summary>
        public string Idvendedor { get => _idvendedor; }
        public string Idhistorial { get => historial.Idhistorial; }

        /// <summary>
        /// Constructor de la clase vendedor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Vendedor(string nombre,string apellido){
            
            _idvendedor = Utiles.GenerarTextoAleatorio(5);
            _nombre = nombre;
            _apellido = apellido;
            GenerarHistorial();
        }

        private void GenerarHistorial()
        {
            historial = new Historial(_idvendedor);
        }

        public void GuardarCotizacion(string idvendedor, Prenda prenda, int cantidad, float preciobase, float preciocalculado, float total)
        {
            historial.CrearCotizacion(idvendedor, prenda, cantidad, preciobase, preciocalculado, total);
        } 
    }
}
