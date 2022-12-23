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

            foreach (Pantalon pantalon in Precios_Stock.ListaPantalones)
            {
                lista.Add(pantalon.ItemString + " Stock " + pantalon.Stock);
            }

            foreach(Camisa camisa in Precios_Stock.ListaCamisas)
            {
                lista.Add(camisa.ItemString + " Stock " + camisa.Stock);
            }

            return lista;
        }
        public List<string> MostrarHistorial()
        {
            List<string> lista = new List<string>();

            foreach (ItemCotizacion item in _vendedor.HistorialVendedor.Cotizaciones)
            {
                lista.Add(item.ItemString);
            }

            return lista;
        }

        #region LOGICA DE NEGOCIO DEL PRESENTADOR

        /// <summary>
        /// Cotiza un pantalon. 
        /// Calidad : 1=Standard, 2=Premium. 
        /// Estilos : 1=Común,2=Chupín. 
        /// </summary>
        /// <param name="idvendedor"></param>
        /// <param name="calidad"></param>
        /// <param name="cantidad"></param>
        /// <param name="preciobase"></param>
        /// <param name="estilo"></param>
        public int Cotizar(ref int stockdisponible, ref float preciocalculado, ref float total, string idvendedor, int cantidad, float preciobase, int calidad, int estilo )
        {

            EstiloPantalon epantalon    = EstiloPantalon.Comun;
            TipoCalidad tcalidad        = TipoCalidad.Standard;

            Pantalon pantalon = new Pantalon();
            pantalon.DiscriminarPrenda(estilo, calidad,ref epantalon,ref tcalidad);

            //Calcula el precio segun la formula y el total del item
            preciocalculado = pantalon.CalcularPrecio(epantalon, tcalidad, preciobase);
            total = preciocalculado * cantidad;

            //Busca el stock y valida si alcanza
            int _pudocotizar = 0;
            _pudocotizar = pantalon.BuscaryActualizarStock(ref stockdisponible, ref pantalon, tcalidad, epantalon, cantidad);

            //Guarda la cotizacion en el historial
            if (_pudocotizar == 1)
            {
                ECPT _ecpt = new ECPT();

                _ecpt.Cantidad = cantidad;
                _ecpt.PrecioBase = preciobase;
                _ecpt.PrecioCalculado = preciocalculado;
                _ecpt.Total = preciocalculado * cantidad;

                _vendedor.GuardarCotizacion(idvendedor, pantalon, _ecpt);
            }


            return _pudocotizar;
        }

        /// <summary>
        /// Cotiza una camisa. 
        /// Tipos de Manga : 1=Corta, 2=Larga. 
        /// Tipos de Cuello: 1=Común, 2=Mao.
        /// Calidad : 1=Standard, 2=Premium. 
        /// </summary>
        /// <param name="idvendedor"></param>
        /// <param name="cantidad"></param>
        /// <param name="preciobase"></param>
        /// <param name="calidad"></param>
        /// <param name="tipomanga"></param>
        /// <param name="tipocuello"></param>
        public int Cotizar(ref int stockdisponible, ref float preciocalculado, ref float total, string idvendedor, int cantidad, float preciobase, int calidad, int tipomanga,int tipocuello )
        {

            TipoManga   tmanga = TipoManga.Corta;
            TipoCuello  tcuello = TipoCuello.Comun;
            TipoCalidad tcalidad =TipoCalidad.Standard;

            Camisa camisa = new Camisa();
            camisa.DiscriminarPrenda(calidad,tipomanga,tipocuello,ref tmanga, ref tcuello, ref tcalidad);

            preciocalculado = camisa.CalcularPrecio(tmanga, tcuello, tcalidad, preciobase);
            total = preciocalculado * cantidad;

            int _pudocotizar = 0;
            _pudocotizar = camisa.BuscaryActualizarStock(ref stockdisponible, ref camisa, tcalidad, tmanga, tcuello, cantidad);
            
            if(_pudocotizar == 1)
            {
                //Se arma la estructura con los datos para guardar el item en el historial
                ECPT _ecpt = new ECPT();

                _ecpt.Cantidad = cantidad;
                _ecpt.PrecioCalculado = preciocalculado;
                _ecpt.PrecioBase = preciobase;
                _ecpt.Total = total;
                
                _vendedor.GuardarCotizacion(idvendedor, camisa, _ecpt);
            }
           
            return _pudocotizar;
        }

        #endregion
    }
}
