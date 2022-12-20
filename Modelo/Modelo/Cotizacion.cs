using System;
using System.Collections.Generic;
using System.Text;

namespace EspacioModelo
{
    class Cotizacion
    {
        int _idcotizacion;

        public Cotizacion()
        {
            NuevaCotizacion();
        }

        public int Idcotizacion { get => _idcotizacion;  }

        private void NuevaCotizacion()
        {
            _idcotizacion += 1;
        }
    }
}
