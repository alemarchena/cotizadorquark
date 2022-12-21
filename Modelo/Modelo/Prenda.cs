using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspacioModelo
{
    /// <summary>
    /// Clase base de una prenda
    /// </summary>
    public abstract class Prenda
    {
        public enum Tipos { Pantalon,Camisa}
        protected Tipos _tipoPrenda;

        public enum Calidades { Standard,Premium }
        protected Calidades _calidad;

        protected int       _idPrenda;
        protected string    _descripcion;
        protected float     _precioBase;
        protected int       _stock;
        protected float     _precio;
        protected string    _itemString;
        public string ItemString { get => _itemString; }

        protected Prenda(Tipos tipoPrenda, int idPrenda,string descripcion,float precioBase, Calidades calidad, int stock)
        {
            _tipoPrenda     = tipoPrenda;
            _idPrenda       = idPrenda;
            _descripcion    = descripcion;
            _precioBase     = precioBase;
            _calidad        = calidad;
            _stock          = stock;
        }

        /// <summary>
        /// Asegura que la prenda tenga un precio desde la creación de la misma
        /// </summary>
        protected abstract void CalcularPrecio();
        /// <summary>
        /// Asegura una descripción expuesta en formato String
        /// </summary>
        protected abstract void GenerarItemString();
    }
}
