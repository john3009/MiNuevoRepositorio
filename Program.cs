using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bievenidos a la calculadora");
            Console.WriteLine("ecriba la operacion que desea hacer" +
                Environment.NewLine + "1. Suma" + 
                Environment.NewLine + "2. resta" +
                Environment.NewLine + "3. Multiplicacion " +
                Environment.NewLine + "4. Division ");

            int operacionARealizar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("escriba el primer numero ");
               double primerNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("escriba el segundo numero ");
            double SegundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado;

            if(operacionARealizar == 1)
            {

                resultado = primerNumero + SegundoNumero;
            }
            else if (operacionARealizar == 2)
            {
                resultado = primerNumero - SegundoNumero;
            }
            else if(operacionARealizar == 3)
            {
                resultado = primerNumero * SegundoNumero;
            }else if (operacionARealizar == 4)
            {
                resultado = primerNumero / SegundoNumero;
            }
            else
            {
                Console.WriteLine("La operacion no es la correcta");
                return;
            }
            Console.WriteLine("el resultado de la operacion es: " + resultado);
            Console.ReadKey();
        }


    }
}
