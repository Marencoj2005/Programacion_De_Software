using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMuyBasica
{
    public class GeneralOperarMath
    {
        public static void suma()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero a sumar"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese numero a sumar"));
            GeneralES.imp(num1 + num2);
        }

        public static void resta()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero a restar"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese numero a restar"));
            GeneralES.imp(num1 - num2);
        }

        public static void multiplicacion()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero a multiplicar"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese numero a multiplicar"));
            GeneralES.imp(num1 * num2);
        }

        public static void division()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero a dividir"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese numero a dividir"));
            GeneralES.imp(num1 / num2);
        }

        public static void potencia()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero base"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese numero exponente"));
            GeneralES.imp(Math.Pow(num1, num2));
        }

        public static void raizCuadradad()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese numero"));

            if (num1 < 0)
            {
                GeneralES.imp("Error, No existe en R, la raiz cuadradad de un numero negativo");

            }

            GeneralES.imp(Math.Sqrt(num1));
        }

        public static void seno()
        {

            double grado = Double.Parse(GeneralES.leer("Ingrese en grados el valor a encontrar"));
            GeneralES.imp(Math.Sin(grado));
        }

        public static void coseno()
        {
            double grado = Double.Parse(GeneralES.leer("Ingrese en grados el valor a encontrar"));
            GeneralES.imp(Math.Cos(grado));
        }

        public static void tangente()
        {
            double grado = Double.Parse(GeneralES.leer("Ingrese en grados el valor a encontrar"));
            GeneralES.imp(Math.Tan(grado));
        }

        public static void modulo()
        {
            double num1 = Double.Parse(GeneralES.leer("Ingrese un numero"));
            double num2 = Double.Parse(GeneralES.leer("Ingrese otro numero"));
            GeneralES.imp(num1 % num2);
        }
    }
}
