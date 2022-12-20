using EspacioEstatico;
using System;
using System.Collections.Generic;
using System.Text;
//using EspacioEstatico;

namespace EspacioModelo
{
    public class Vendedor
    {
        string  _idvendedor;
        string  _nombre;
        string  _apellido;
        string  _idhistorial;

        /// <summary>
        /// La propiedad Idvendedor se genera automáticamente cuando es creado el vendedor
        /// </summary>
        public string Idvendedor { get => _idvendedor; }

        /// <summary>
        /// Constructor de la clase vendedor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Vendedor(string nombre,string apellido){
            
            _idvendedor = GenerarVendedor(nombre,apellido);
            _nombre = nombre;
            _apellido = apellido;
            GenerarHistorial();
        }

        private void GenerarHistorial()
        {
            Historial historial = new Historial(_idvendedor);
            _idhistorial = historial.Idhistorial;
        }

        private string GenerarVendedor(string nombre,string apellido)
        {

            return "";
        }

    }
}
