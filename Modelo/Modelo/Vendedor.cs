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
        Historial _historial;
        //public struct preciostock
        //{
        //    public float _precio;
        //    public int _stock;
        //}
        /// <summary>
        /// La propiedad Idvendedor se genera automáticamente cuando es creado el vendedor
        /// </summary>
        public string Idvendedor { get => _idvendedor; }
        public string Idhistorial { get => _historial.Idhistorial; }
        public Historial HistorialVendedor { get => _historial; }

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
            _historial = new Historial(_idvendedor);
        }

        public void GuardarCotizacion(string idvendedor, Prenda prenda, ECPT ecpt)
        {
            _historial.CrearCotizacion(idvendedor, prenda, ecpt);
        } 
    }
}
