using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro();
            //car1.Encendido = true; 
            car1.Avanzar(15);

            Console.WriteLine($"el carro {car1.Color} va a una velocidad de {car1.Velocidad}");


          

            Console.ReadKey();
        }
    }
}
