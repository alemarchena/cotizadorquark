using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioModelo
{
    /// <summary>
    /// Genera un stock automático predeterminado para el caso
    /// </summary>
     public static class Precios_Stock
    {
        static List<Prenda> _listaPrendas;

        public static List<Prenda> ListaPrendas { get => _listaPrendas;  }

        

        public static void GenerarListaConStock()
        {
            _listaPrendas = new List<Prenda>();
            CreaStokPantalones();
            CreaStokCamisas();
        }


        private static void CreaStokPantalones() {

            //Chupines
            _listaPrendas.Add(new Pantalon(TipoPrenda.Pantalon, 1, "Pantalón", 100, TipoCalidad.Standard, 750, EstiloPantalon.Chupin));
            _listaPrendas.Add(new Pantalon(TipoPrenda.Pantalon, 2, "Pantalón", 100, TipoCalidad.Premium, 750, EstiloPantalon.Chupin));

            //Comunes
            _listaPrendas.Add(new Pantalon(TipoPrenda.Pantalon, 3, "Pantalón", 100, TipoCalidad.Standard, 250, EstiloPantalon.Comun));
            _listaPrendas.Add(new Pantalon(TipoPrenda.Pantalon, 4, "Pantalón", 100, TipoCalidad.Premium, 250, EstiloPantalon.Comun));
        }

        private static void CreaStokCamisas()
        {
            //Manga Corta
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 5,"Camisa",100,TipoCalidad.Standard,100, TipoManga.Corta,TipoCuello.Mao));
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 6, "Camisa",100, TipoCalidad.Premium,100, TipoManga.Corta,TipoCuello.Mao));

            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 7, "Camisa", 100, TipoCalidad.Standard, 150, TipoManga.Corta, TipoCuello.Comun));
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 8, "Camisa", 100, TipoCalidad.Premium, 150, TipoManga.Corta, TipoCuello.Comun));

            //Manga Larga
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 9, "Camisa", 100, TipoCalidad.Standard, 75, TipoManga.Larga, TipoCuello.Mao));
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 10, "Camisa", 100, TipoCalidad.Premium, 75, TipoManga.Larga, TipoCuello.Mao));

            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 11, "Camisa", 100, TipoCalidad.Standard, 175, TipoManga.Larga, TipoCuello.Comun));
            _listaPrendas.Add(new Camisa(TipoPrenda.Camisa, 12, "Camisa", 100, TipoCalidad.Premium, 175, TipoManga.Larga, TipoCuello.Comun));
        }

    }
}
