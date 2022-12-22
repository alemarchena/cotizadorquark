using System;


namespace EspacioModelo
{
    sealed class ItemCotizacion
    {
        string      _idvendedor;
        string      _idcotizacion;
        DateTime    _fechahora;
        Prenda      _prenda;
        int         _cantidad;
        float       _preciobase;
        float       _preciocalculado;
        float       _total;

        public string Idcotizacion { get => _idcotizacion;  }

        public ItemCotizacion(string idvendedor,Prenda prenda,int cantidad,float preciobase,float preciocalculado,float total)
        {
            _fechahora = new DateTime();
            _idvendedor = idvendedor;
            _idcotizacion = idvendedor + "#" + _fechahora;
            _cantidad = cantidad;
            _prenda = prenda;
            _preciobase = preciobase;
            _total = total;
            _preciocalculado = preciocalculado;

        }

       
    }

}
