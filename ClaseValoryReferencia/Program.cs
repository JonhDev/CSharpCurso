using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseValoryReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //OperacionesBasicas(10, 8,out int num1,out int num2,out int num3,out float num4);
            //Console.WriteLine($" La suma es {num1}\nLa resta es {num2}\nLa Multi es {num3}\nLa division es: {num4} ");
            //DobleFactorial(9, out int factorialDoble);
            //Console.WriteLine("El doble factorial de 9 es: {0}", factorialDoble);
            Console.ReadKey();
        }

        static void OperacionesBasicas(int num1, int num2, out int suma, out int resta, out int multi, out float division)
        {
            suma = num1 + num2;
            resta = num1 - num2;
            multi = num1 * num2;
            division = (float) num1 / num2;
        }

        static void DobleFactorial(int num, out int numDobleFactorial)
        {
            int valor;
            numDobleFactorial = 1;
            if ((num % 2) == 0)
                valor = 2;
            else
                valor = 1;

            for (int i = valor; i <= num; i+=2)
                numDobleFactorial *= i;
        }
        
    }
}