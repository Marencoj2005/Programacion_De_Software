using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMuyBasica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GeneralES.imp("==== CALCULADORA MUY BASICA ====");
            int op = 0;
            do
            {
                op = Int32.Parse(GeneralES.leer("Ingrese la Operación a realizar\n"+
                    "1.Suma\n"+
                    "2.Resta\n"+
                    "3.Multiplicacion\n"+
                    "4.Division\n"+
                    "5.Modulo\n"+
                    "6.Potencia\n"+
                    "7.Raiz cuadrada\n"+
                    "8.Seno\n"+
                    "9.Coseno\n"+
                    "10.Tangente\n"+
                    "0.Salir"));

                switch (op)
                {
                    case 1:
                        GeneralOperarMath.suma();
                        break;
                    case 2:
                        GeneralOperarMath.resta();
                        break;
                    case 3:
                        GeneralOperarMath.multiplicacion();
                        break;
                    case 4:
                        GeneralOperarMath.division();
                        break;
                    case 5:
                        GeneralOperarMath.modulo();
                        break;
                    case 6:
                        GeneralOperarMath.potencia();
                        break;
                    case 7:
                        GeneralOperarMath.raizCuadradad();
                        break;
                    case 8:
                        GeneralOperarMath.seno();
                        break;
                    case 9:
                        GeneralOperarMath.coseno();
                        break;
                    case 10:
                        GeneralOperarMath.tangente();
                        break;
                    case 0:
                        GeneralES.imp("Chao");
                        break;
                    default:
                        GeneralES.imp("Error!, Opción incorrecta");
                        break;
                }
            } while (op != 0);
        }
    }
}
