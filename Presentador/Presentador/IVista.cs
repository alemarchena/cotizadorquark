
using EspacioModelo;

namespace EspacioPresentador
{
    public interface IVista
    {
        string CrearVendedor(string nombre, string apellido);
        /// <summary>
        /// Cree una variable _presentador de alcance de la clase, e instancie un objeto Presentador en ella.
        /// </summary>
        void CrearPresentador();

    }
}
