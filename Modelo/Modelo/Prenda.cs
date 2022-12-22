using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EspacioModelo.Pantalon;

namespace EspacioModelo
{
    /// <summary>
    /// Clase base de una prenda
    /// </summary>
    public abstract class Prenda
    {
        protected TipoPrenda _tipoPrenda;
        protected TipoCalidad _calidad;

        protected int       _idPrenda;
        protected string    _descripcion;
        protected float     _precioBase;
        protected int       _stock;
        protected float     _precio;
        protected string    _itemString;
        public string ItemString { get => _itemString; }
        public TipoPrenda TipoPrenda { get => _tipoPrenda; }

        protected Prenda(TipoPrenda tipoPrenda, int idPrenda,string descripcion,float precioBase, TipoCalidad calidad, int stock)
        {
            _tipoPrenda     = tipoPrenda;
            _idPrenda       = idPrenda;
            _descripcion    = descripcion;
            _precioBase     = precioBase;
            _calidad        = calidad;
            _stock          = stock;
        }

        protected Prenda() { }
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
