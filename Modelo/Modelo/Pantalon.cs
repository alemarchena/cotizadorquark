using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EspacioModelo.Prenda;

namespace EspacioModelo
{
    sealed public class Pantalon : Prenda
    {
        EstiloPantalon _estilo;
        internal EstiloPantalon Estilo { get => Estilo; set => Estilo = value; }

        public Pantalon(TipoPrenda tipoPrenda, int idPrenda, string descripcion, float precioBase, TipoCalidad calidad, int stock, EstiloPantalon estilo) : base(tipoPrenda, idPrenda, descripcion, precioBase, calidad, stock)
        {
            _tipoPrenda = tipoPrenda;
            _idPrenda   = idPrenda;
            _descripcion= descripcion;
            _precioBase = precioBase;
            _calidad    = calidad;
            _stock      = stock;
            _estilo     = estilo;

            CalcularPrecio();
            GenerarItemString();
        }

        public Pantalon() { }

        protected override void CalcularPrecio()
        {
            _precio =  Formula(_estilo, _calidad, _precioBase);
        }

        public float CalcularPrecio(EstiloPantalon estilo,TipoCalidad calidad,float precio)
        {
            return Formula(estilo,calidad,precio);
        }

        private float Formula(EstiloPantalon estilo, TipoCalidad calidad, float precio)
        {
            float precioCalculado;
            
            precioCalculado = estilo == EstiloPantalon.Chupin ? precio - precio * 12 / 100 : precio;
            precioCalculado += calidad == TipoCalidad.Premium ? precio * 30 / 100 : 0;

            return precioCalculado;
        }
        
        protected override void GenerarItemString()
        {
            _itemString = "Cód " + _idPrenda.ToString() + " " + _descripcion + " " + _estilo.ToString() + " " + _calidad.ToString() + " $" + _precio.ToString() + " Stock: " + _stock.ToString();
        }

    }
}
