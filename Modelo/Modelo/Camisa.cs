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
    sealed class Camisa : Prenda
    {
        public enum TipoManga { Corta, Larga }
        TipoManga _tipoManga;

        public enum TipoCuello { Comun, Mao}
        TipoCuello _tipoCuello;

        public Camisa(Tipos tipoPrenda, int idPrenda, string descripcion, float precioBase, Calidades calidad, int stock,TipoManga tipoManga,TipoCuello tipoCuello) : base(tipoPrenda, idPrenda, descripcion, precioBase, calidad, stock)
        {
            _tipoPrenda = tipoPrenda;
            _idPrenda = idPrenda;
            _descripcion = descripcion;
            _precioBase = precioBase;
            _calidad = calidad;
            _stock = stock;
            _tipoManga = tipoManga;
            _tipoCuello = tipoCuello;

            CalcularPrecio();
            GenerarItemString();

        }

        protected override void CalcularPrecio()
        {
            _precio = Formula(_tipoManga,_tipoCuello, _calidad,_precioBase);
        }
        public float CalcularPrecio(TipoManga tipoManga, TipoCuello tipoCuello, Calidades calidad, float precio)
        {
            return Formula(tipoManga, tipoCuello, calidad, precio);
        }

        private float Formula(TipoManga tipoManga, TipoCuello tipoCuello, Calidades calidad, float precio)
        {
            float precioCalculado;

            precioCalculado = tipoManga == TipoManga.Corta ? precio - precio * 10 / 100 : precio;
            precioCalculado += tipoCuello == TipoCuello.Mao ? precio * 3 / 100 : 0;
            precioCalculado += calidad == Calidades.Premium ? precio * 30 / 100 : 0;

            return precioCalculado;
        }

        protected override void GenerarItemString()
        {
            _itemString = "Cód " + _idPrenda.ToString() + " " + _descripcion + " Manga " + _tipoManga.ToString() + " Cuello " + _tipoCuello.ToString() + " " + _calidad.ToString() + " $" + _precio.ToString() + " Stock: " + _stock.ToString();
        }
    }
}
