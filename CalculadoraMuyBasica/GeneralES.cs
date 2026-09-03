using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMuyBasica
{
    public class GeneralES
    {
        public static void imp(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public static void imp(double n)
        {
            imp("Resultado: " + n);
        }

        public static string leer(string mensaje)
        {
            imp(mensaje);
            return System.Console.ReadLine();
        }

      
    }

}
