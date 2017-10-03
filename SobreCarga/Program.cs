using System;
using ClasePOO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,res;
            Console.WriteLine("inserte n1: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("inserte n2: ");
            n2=int.Parse(Console.ReadLine());
            res =Suma(1, 2, 3, 4, 5);
            Console.WriteLine($"el resultado es {res}");

            Console.ReadKey();
        }

        static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Suma(int n1 = 10, int n2 = 9, int n3 = 6, int n4 = 4)
        {
            return n1 + n2 + n3+n4;
        }

        static int Suma(params int[] numeros)
        {
            int suma = 0;
            foreach (int item in numeros)
            {
                suma += item;
            }
            return suma;
        }

    }
}
