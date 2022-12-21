using System;

namespace EspacioModelo
{
    sealed public class Tienda
    {
        string _nombre;
        string _direccion;
        public Tienda(string nombre,string direccion)
        {
            _nombre = nombre;
            _direccion = direccion;
        }

        public string Nombre { get => _nombre; }
        public string Direccion { get => _direccion; }
    }
}
