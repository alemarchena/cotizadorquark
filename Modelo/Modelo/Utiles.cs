using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EspacioModelo
{
    static  class Utiles
    {

        private static Random random = new Random();

        public static string GenerarTextoAleatorio(int largo)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-#$";
            return new string(Enumerable.Repeat(caracteres, largo)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
