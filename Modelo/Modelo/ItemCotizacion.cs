using System;


namespace EspacioModelo
{
    sealed public class ItemCotizacion
    {
        string      _idvendedor;
        string      _idcotizacion;
        string      _fechahora;
        Prenda      _prenda;
        int         _cantidad;
        float       _preciobase;
        float       _preciocalculado;
        float       _total;
        string      _itemString;

        public string Idcotizacion { get => _idcotizacion;  }
        public string ItemString { get => _itemString; set => _itemString = value; }

        public ItemCotizacion(string idvendedor,Prenda prenda, ECPT ecpt)
        {
            _prenda         = prenda;
            _fechahora      = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh:mm:ss");
            _idvendedor     = idvendedor;
            _idcotizacion   = idvendedor + "#" + _fechahora;

            _cantidad       = ecpt.Cantidad;
            _preciobase     = ecpt.PrecioBase;
            _total          = ecpt.Total;
            _preciocalculado= ecpt.PrecioCalculado;

            GenerarItemString(this);
        }

        private void GenerarItemString(ItemCotizacion item)
        {
            item.ItemString = item._fechahora.ToString() + " - " +
            item._prenda.ItemString + 
            " Cantidad:" + item._cantidad + 
            " $" + item._preciocalculado + 
            " Total $" + item._total + " ";
        }
    }

}
