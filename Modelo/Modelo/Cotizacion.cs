using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    sealed class Cotizacion
    {
        string _idcotizacion;
        DateTime _fechahora;
        List<Item> items;
        public string Idcotizacion { get => _idcotizacion;  }

        public Cotizacion(string idVendedor)
        {
            _fechahora = new DateTime();
            _idcotizacion = idVendedor + "#" + _fechahora;
            items = new List<Item>();
        }

      
    }

}
