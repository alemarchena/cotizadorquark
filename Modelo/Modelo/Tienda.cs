using EspacioEstatico;
using System;

namespace EspacioModelo
{
    public class Tienda
    {
        string _nombre;
        string _direccion;
        public Tienda(string nombre,string direccion)
        {
            Vendedores.GenerarVendedor();
            Nombre = nombre;
            _direccion = direccion;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
