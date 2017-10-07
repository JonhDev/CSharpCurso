using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        public string NomBiblioteca {get; set;}

        List<Libro> nombre = new List<Libro>();

        public void Agregar()
        {
            nombre.Add(new Libro() { Nombre="Juanito banana",Autor="pepe",Editorial="Porton"});
            nombre[0] = new Libro() { Nombre = "lo que es", Autor = "pepe 2", Editorial = "Portin" };
        }

        public void ImpLib()
        {
            Agregar();
            foreach( Libro item in nombre)
            {
                Console.WriteLine(item);
            }
                
                
            
        }
        
    }

}
