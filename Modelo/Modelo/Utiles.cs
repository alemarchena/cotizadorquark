using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EspacioModelo
{
    /// <summary>
    /// Provee de tipos de datos y funcionalidad específica del sistema.
    /// </summary>
    static class Utiles
    {

        private static Random random = new Random();

        public static string GenerarTextoAleatorio(int largo)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-#$";
            return new string(Enumerable.Repeat(caracteres, largo)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
  
    /// <summary>
    /// EPT : Estructura con cantidad,precios y total
    /// </summary>
    public struct ECPT
    {
        public int   Cantidad;
        public float PrecioBase;
        public float PrecioCalculado;
        public float Total;
    }

    public enum TipoPrenda { Pantalon, Camisa }
    public enum TipoCalidad { Standard, Premium }
    public enum EstiloPantalon { Comun,Chupin }
    public enum TipoManga { Corta, Larga }
    public enum TipoCuello { Comun, Mao }

    
}
