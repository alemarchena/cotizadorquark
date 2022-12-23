using EspacioModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EspacioModelo.Camisa;
using static EspacioModelo.Pantalon;
using static EspacioModelo.Prenda;

namespace EspacioModelo
{
    sealed public class Camisa : Prenda
    {
        TipoManga _tipoManga;
        TipoCuello _tipoCuello;
        public TipoManga TipoManga { get => _tipoManga; }
        public TipoCuello TipoCuello { get => _tipoCuello; }
        public Camisa(TipoPrenda tipoPrenda, int idPrenda, string descripcion, float precioBase, TipoCalidad calidad, int stock,TipoManga tipoManga,TipoCuello tipoCuello) : base(tipoPrenda, idPrenda, descripcion, precioBase, calidad, stock)
        {
            _tipoPrenda     = tipoPrenda;
            _idPrenda       = idPrenda;
            _descripcion    = descripcion;
            _precioBase     = precioBase;
            _calidad        = calidad;
            _stock          = stock;
            _tipoManga      = tipoManga;
            _tipoCuello     = tipoCuello;

            CalcularPrecio();
            GenerarItemString(this);

        }

        public Camisa() { }

        protected override void CalcularPrecio()
        {
            _precio = Formula(_tipoManga,_tipoCuello, _calidad,_precioBase);
        }
        public float CalcularPrecio(TipoManga tipoManga, TipoCuello tipoCuello, TipoCalidad calidad, float precio)
        {
            return Formula(tipoManga, tipoCuello, calidad, precio);
        }

        private float Formula(TipoManga tipoManga, TipoCuello tipoCuello, TipoCalidad calidad, float precio)
        {
            float precioCalculado;

            precioCalculado = tipoManga == TipoManga.Corta ? precio - precio * 10 / 100 : precio;
            precioCalculado += tipoCuello == TipoCuello.Mao ? precio * 3 / 100 : 0;
            precioCalculado += calidad == TipoCalidad.Premium ? precio * 30 / 100 : 0;

            return precioCalculado;
        }

        public void DiscriminarPrenda(int calidad, int tipomanga, int tipocuello,ref TipoManga tmanga, ref TipoCuello tcuello, ref TipoCalidad tcalidad) 
        {
            if (tipomanga == 1 && tipocuello == 1 && calidad == 1)
            { tmanga = TipoManga.Corta; tcuello = TipoCuello.Comun; tcalidad = TipoCalidad.Standard; }

            if (tipomanga == 1 && tipocuello == 1 && calidad == 2)
            { tmanga = TipoManga.Corta; tcuello = TipoCuello.Comun; tcalidad = TipoCalidad.Premium; }

            if (tipomanga == 1 && tipocuello == 2 && calidad == 1)
            { tmanga = TipoManga.Corta; tcuello = TipoCuello.Mao; tcalidad = TipoCalidad.Standard; }

            if (tipomanga == 1 && tipocuello == 2 && calidad == 2)
            { tmanga = TipoManga.Corta; tcuello = TipoCuello.Mao; tcalidad = TipoCalidad.Premium; }

            if (tipomanga == 2 && tipocuello == 1 && calidad == 1)
            { tmanga = TipoManga.Larga; tcuello = TipoCuello.Comun; tcalidad = TipoCalidad.Standard; }

            if (tipomanga == 2 && tipocuello == 1 && calidad == 2)
            { tmanga = TipoManga.Larga; tcuello = TipoCuello.Comun; tcalidad = TipoCalidad.Premium; }

            if (tipomanga == 2 && tipocuello == 2 && calidad == 1)
            { tmanga = TipoManga.Larga; tcuello = TipoCuello.Mao; tcalidad = TipoCalidad.Standard; }

            if (tipomanga == 2 && tipocuello == 2 && calidad == 2)
            { tmanga = TipoManga.Larga; tcuello = TipoCuello.Mao; tcalidad = TipoCalidad.Premium; }
        }

        /// <summary>
        /// Busca la cantidad de stock.
        /// Devuelve 0=No alcanza, 1=Si alcanza el stock.
        /// </summary>
        /// <param name="stockdisponible"></param>
        /// <param name="prenda"></param>
        /// <param name="tcalidad"></param>
        /// <param name="tmanga"></param>
        /// <param name="tcuello"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public int BuscaryActualizarStock
            (ref int stockdisponible, ref Camisa prenda, TipoCalidad tcalidad,TipoManga tmanga,TipoCuello tcuello,int cantidad)
        {
            int _pudocotizar = 0;

            for (int a = 0; a < Precios_Stock.ListaCamisas.Count; a++)
            {

                if (tcalidad == Precios_Stock.ListaCamisas[a].Calidad &&
                    tmanga == Precios_Stock.ListaCamisas[a].TipoManga &&
                    tcuello == Precios_Stock.ListaCamisas[a].TipoCuello)
                {
                    if (Precios_Stock.ListaCamisas[a].Stock >= cantidad)
                    {
                        prenda = Precios_Stock.ListaCamisas[a];
                        stockdisponible = Precios_Stock.ListaCamisas[a].Stock;

                        Precios_Stock.ListaCamisas[a].RestarStock(cantidad);
                        GenerarItemString(Precios_Stock.ListaCamisas[a]);

                        _pudocotizar = 1;
                    }
                }
            }
            return _pudocotizar;
        }

        private void GenerarItemString(Camisa prenda)
        {
            prenda.ItemString = "Cód " + prenda.IdPrenda.ToString() + " " +
            prenda.Descripcion + " Manga " +
            prenda.TipoManga.ToString() + " Cuello " +
            prenda.TipoCuello.ToString() + " " +
            prenda.Calidad.ToString() + " $" +
            prenda.PrecioBase.ToString();
        }
    }
}
