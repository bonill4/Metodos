using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            //mensajePantalla();

            //Console.WriteLine($"El resultaod es: {sumarNumeros(7,9)}");
            //Console.WriteLine($"El resultado es: {sumarNumeros(7, 8.5)}");
            //Console.WriteLine($"El resultado es: {sumarNumeros(7, 8, 5)}");

            int val1 = 7;
            double val2 = 5.2;
            double val3 = 8.3;

            Console.WriteLine(Suma(val1, val2, val3));
        }

        //Los metodos con "void" no devuelven valor
        static void mensajePantalla()
        {
            Console.WriteLine("Mensaje desde el Metodo");
        }

        //Los que inician con un tipo de variable sip retornan valor
        //Forma simplificada si solo tiene 1 linea de codigo

        //-------------------------SOBRECARGA DE METODOS-----------------------------------
        /*Para ello se necesita que los tipos de datos
         * sean diferentes o que la  antidad de 
         * parametros sean diferentes*/
        static int sumarNumeros(int num1, int num2) => num1 + num2;

        static double sumarNumeros(int num1, double num2) => num1 + num2;

        static int sumarNumeros(int num1, int num2, int num3) => num1 + num2 + num3;

        //-------------------------PARAMETROS OPCIONALES-----------------------------------
        private static double Suma(int val1, double val2, double val3 = 0)
        {
            return val1 + val2 + val3;
        }
    }
}
