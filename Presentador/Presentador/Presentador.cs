using System;
using EspacioModelo;

namespace EspacioPresentador
{
    public class Presentador
    {
        Vendedor _vendedor;

        public Presentador()
        {

        }

        public string CrearVendedor(string nombre, string apellido)
        {
            _vendedor = new Vendedor(nombre, apellido);
            return _vendedor.Idvendedor;
        }
    }
}
