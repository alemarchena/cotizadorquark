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
            _listaPrendas.Add(new Pantalon(Prenda.Tipos.Pantalon, 1, "Pantalón", 100, Prenda.Calidades.Standard, 750, Pantalon.EstiloPantalon.Chupin));
            _listaPrendas.Add(new Pantalon(Prenda.Tipos.Pantalon, 2, "Pantalón", 100, Prenda.Calidades.Premium, 750, Pantalon.EstiloPantalon.Chupin));

            //Comunes
            _listaPrendas.Add(new Pantalon(Prenda.Tipos.Pantalon, 3, "Pantalón", 100, Prenda.Calidades.Standard, 250, Pantalon.EstiloPantalon.Comun));
            _listaPrendas.Add(new Pantalon(Prenda.Tipos.Pantalon, 4, "Pantalón", 100, Prenda.Calidades.Premium, 250, Pantalon.EstiloPantalon.Comun));
        }

        private static void CreaStokCamisas()
        {
            //Manga Corta
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 5,"Camisa",100,Prenda.Calidades.Standard,100, Camisa.TipoManga.Corta,Camisa.TipoCuello.Mao));
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 6, "Camisa",100,Prenda.Calidades.Premium,100, Camisa.TipoManga.Corta,Camisa.TipoCuello.Mao));

            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 7, "Camisa", 100, Prenda.Calidades.Standard, 150, Camisa.TipoManga.Corta, Camisa.TipoCuello.Comun));
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 8, "Camisa", 100, Prenda.Calidades.Premium, 150, Camisa.TipoManga.Corta, Camisa.TipoCuello.Comun));

            //Manga Larga
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 9, "Camisa", 100, Prenda.Calidades.Standard, 75, Camisa.TipoManga.Larga, Camisa.TipoCuello.Mao));
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 10, "Camisa", 100, Prenda.Calidades.Premium, 75, Camisa.TipoManga.Larga, Camisa.TipoCuello.Mao));

            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 11, "Camisa", 100, Prenda.Calidades.Standard, 175, Camisa.TipoManga.Larga, Camisa.TipoCuello.Comun));
            _listaPrendas.Add(new Camisa(Prenda.Tipos.Camisa, 12, "Camisa", 100, Prenda.Calidades.Premium, 175, Camisa.TipoManga.Larga, Camisa.TipoCuello.Comun));
        }

    }
}
