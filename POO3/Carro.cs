using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Carro
    {
        public Carro()
        {
            Encendido = false;
            Color = "Amarillo";
            Velocidad = 0;
        }
        public bool Encendido { get; set; }
        public string Color { get; }// get ->(obtener) lectura set->(colocar) escritura
        public int Velocidad { get; set; }
         public void Avanzar(int velocidad)
        {
            if (Encendido)
            {
                Velocidad = velocidad;
            } 
            else
            {
                Console.WriteLine("El coche esta apagado");
            }

      
        }
    }
}
