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
        public EstiloPantalon Estilo { get => _estilo; }

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
            GenerarItemString(this);
        }

        public Pantalon() { }

        protected override void CalcularPrecio()
        {
            _preciocalculado =  Formula(_estilo, _calidad, _precioBase);
        }

        public float CalcularPrecio(EstiloPantalon estilo,TipoCalidad calidad,float precio)
        {
            return Formula(estilo,calidad,precio);
        }

        /// <summary>
        /// Determina el tipo de pantalón segun su confección
        /// </summary>
        /// <param name="estilo"></param>
        /// <param name="calidad"></param>
        /// <param name="epantalon"></param>
        /// <param name="tcalidad"></param>
        public void DiscriminarPrenda(int estilo,int calidad,ref EstiloPantalon epantalon,ref TipoCalidad tcalidad)
        {
            if (estilo == 1 && calidad == 1)
            { epantalon = EstiloPantalon.Comun; tcalidad = TipoCalidad.Standard; }

            if (estilo == 1 && calidad == 2)
            { epantalon = EstiloPantalon.Comun; tcalidad = TipoCalidad.Premium; }

            if (estilo == 2 && calidad == 1)
            { epantalon = EstiloPantalon.Chupin; tcalidad = TipoCalidad.Standard; }

            if (estilo == 2 && calidad == 2)
            { epantalon = EstiloPantalon.Chupin; tcalidad = TipoCalidad.Premium; }
        }

        /// <summary>
        /// Busca un producto, evalúa si el stock alcanza para ser cotizado y lo actualiza
        /// Devuelve 0=No alcanza, 1=Si alcanza el stock.
        /// </summary>
        /// <param name="stockdisponible"></param>
        /// <param name="prenda"></param>
        /// <param name="tcalidad"></param>
        /// <param name="testilo"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public int BuscaryActualizarStock(ref int stockdisponible, ref Pantalon prenda, TipoCalidad tcalidad, EstiloPantalon testilo,int cantidad)
        {
            int _pudocotizar = 0;

            for (int a = 0; a < Precios_Stock.ListaPantalones.Count; a++)
            {
                if (tcalidad == Precios_Stock.ListaPantalones[a].Calidad &&
                    testilo== Precios_Stock.ListaPantalones[a].Estilo) 
                {
                    if (Precios_Stock.ListaPantalones[a].Stock >= cantidad)
                    {
                        prenda = Precios_Stock.ListaPantalones[a];
                        stockdisponible = Precios_Stock.ListaPantalones[a].Stock;

                        Precios_Stock.ListaPantalones[a].RestarStock(cantidad);
                        GenerarItemString(Precios_Stock.ListaPantalones[a]);

                        _pudocotizar = 1;
                    }
                }
            }
            return _pudocotizar;
        }

       
        private float Formula(EstiloPantalon estilo, TipoCalidad calidad, float precio)
        {
            float precioCalculado;
            
            precioCalculado = estilo == EstiloPantalon.Chupin ? precio - precio * 12 / 100 : precio;
            precioCalculado += calidad == TipoCalidad.Premium ? precio * 30 / 100 : 0;

            return precioCalculado;
        }

        private void GenerarItemString(Pantalon prenda)
        {
            prenda.ItemString = "Cód " + prenda.IdPrenda.ToString() + " " +
            prenda.Descripcion + " " +
            prenda.Estilo.ToString() + " " +
            prenda.Calidad.ToString() + " $" +
            prenda.PrecioBase.ToString();
        }

    }
}
