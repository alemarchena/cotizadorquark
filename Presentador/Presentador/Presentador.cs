using System;
using System.Collections.Generic;
using EspacioModelo;

namespace EspacioPresentador
{
    public class Presentador
    {
        Vendedor _vendedor;
        Tienda  _tienda;

        public Presentador()
        {
            Precios_Stock.GenerarListaConStock();
        }
        public void CrearTienda(string nombre,string direccion)
        {
            _tienda = new Tienda(nombre,direccion);
        }

        public string CrearVendedor(string nombre, string apellido)
        {
            _vendedor = new Vendedor(nombre, apellido);
            return _vendedor.Idvendedor;
        }

        public string MostrarIdHistorialVendedor()
        {
            return _vendedor.Idhistorial;
        }


        public List<string> MostrarPrendas()
        {
            List<string> lista = new List<string>();

            foreach(Prenda prenda in Precios_Stock.ListaPrendas)
            {
                lista.Add(prenda.ItemString);
            }

            return lista;
        }
    }
}
