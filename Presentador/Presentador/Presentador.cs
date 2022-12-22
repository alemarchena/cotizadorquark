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

        
        /// <summary>
        /// Cotiza un pantalon. 
        /// Calidad : 1=Standard, 2=Premium. 
        /// Estilos : 1=Común,2=Chupín. 
        /// </summary>
        /// <param name="idvendedor"></param>
        /// <param name="calidad"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="estilo"></param>
        public void Cotizar(ref int stockdisponible, ref float preciocalculado, ref float total, string idvendedor, int cantidad, float precio, int calidad, int estilo )
        {

            Epreciostock resultado = new Epreciostock();
            
            Pantalon p = new Pantalon();
            if(estilo == 1 && calidad == 1)
                resultado.Precio = p.CalcularPrecio(EstiloPantalon.Comun, TipoCalidad.Standard, precio);
            if(estilo == 1 && calidad == 2)
                resultado.Precio = p.CalcularPrecio(EstiloPantalon.Comun, TipoCalidad.Premium, precio);

            if (estilo == 2 && calidad == 1)
                resultado.Precio = p.CalcularPrecio(EstiloPantalon.Chupin, TipoCalidad.Standard, precio);
            if (estilo == 2 && calidad == 2)
                resultado.Precio = p.CalcularPrecio(EstiloPantalon.Chupin, TipoCalidad.Premium, precio);

            AsignaReferencias(ref stockdisponible, ref preciocalculado, ref total, resultado.Precio, cantidad);

        }

        /// <summary>
        /// Cotiza una camisa. 
        /// Tipos de Manga : 1=Corta, 2=Larga. 
        /// Tipos de Cuello: 1=Común, 2=Mao.
        /// Calidad : 1=Standard, 2=Premium. 
        /// </summary>
        /// <param name="idvendedor"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="calidad"></param>
        /// <param name="tipoManga"></param>
        /// <param name="tipocuello"></param>
        public void Cotizar(ref int stockdisponible, ref float preciocalculado, ref float total, string idvendedor, int cantidad, float precio, int calidad, int tipoManga,int tipocuello )
        {

            Epreciostock resultado = new Epreciostock();
            Camisa c = new Camisa();

            if(tipoManga == 1 && tipocuello == 1 && calidad == 1)
            resultado.Precio = c.CalcularPrecio(TipoManga.Corta,TipoCuello.Comun,TipoCalidad.Standard,precio);
            if(tipoManga == 1 && tipocuello == 1 && calidad == 2)
            resultado.Precio = c.CalcularPrecio(TipoManga.Corta, TipoCuello.Comun, TipoCalidad.Premium, precio);
            if (tipoManga == 1 && tipocuello == 2 && calidad == 1)
            resultado.Precio = c.CalcularPrecio(TipoManga.Corta, TipoCuello.Mao, TipoCalidad.Standard, precio);
            if (tipoManga == 1 && tipocuello == 2 && calidad == 2)
            resultado.Precio = c.CalcularPrecio(TipoManga.Corta, TipoCuello.Mao, TipoCalidad.Premium, precio);


            if (tipoManga == 2 && tipocuello == 1 && calidad == 1)
            resultado.Precio = c.CalcularPrecio(TipoManga.Larga, TipoCuello.Comun, TipoCalidad.Standard, precio);
            if (tipoManga == 2 && tipocuello == 1 && calidad == 2)
            resultado.Precio = c.CalcularPrecio(TipoManga.Larga, TipoCuello.Comun, TipoCalidad.Premium, precio);
            if (tipoManga == 2 && tipocuello == 2 && calidad == 1)
            resultado.Precio = c.CalcularPrecio(TipoManga.Larga, TipoCuello.Mao, TipoCalidad.Standard, precio);
            if (tipoManga == 2 && tipocuello == 2 && calidad == 2)
            resultado.Precio = c.CalcularPrecio(TipoManga.Larga, TipoCuello.Mao, TipoCalidad.Premium, precio);

            AsignaReferencias(ref stockdisponible, ref preciocalculado, ref total, resultado.Precio, cantidad);

        }

        private void AsignaReferencias(ref int stockdisponible, ref float preciocalculado, ref float total,float precio,int cantidad) {
            preciocalculado = precio;
            total = precio * cantidad;
            stockdisponible = 0;
        }
    }
}
