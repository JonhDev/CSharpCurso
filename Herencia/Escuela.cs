using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public enum Personal
    {
        Profesor,
        Alumno,
        Achichincle
    }

    class Escuela
    {
        const int PROFESOR = 0;
        const int ALUMNO = 1;
        const int ADMINISTRATIVO = 2;

        

        List<Estudiante> alumnos = new List<Estudiante>();
        List<Profesor> maestros = new List<Profesor>();
        List<Administracion> administradores = new List<Administracion>();
        public string Nombre {get;}
        public string Ubicacion {get;}
        public int NAlumnos { get { return alumnos.Count; } }

        public Escuela(string nombre, string ubicacion)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
        }

        public void Agregar (Estudiante estudiante)
        {
            alumnos.Add(estudiante);
        }
        
        public void Agregar (Administracion administrador)
        {
            administradores.Add(administrador);
        }

        public void Agregar (Profesor profesor)
        {
            maestros.Add(profesor);
        }

        public void Consultar(Personal opcion)
        {
            switch (opcion)
            {
                case Personal.Alumno:
                    foreach (Estudiante item in alumnos)
                    {
                        Console.WriteLine($"alumno: {item.Nombre}");
                    }
                    break;

                case Personal.Profesor:
                    foreach (Profesor item in maestros)
                    {
                        Console.WriteLine($"maestros: {item.Nombre}");
                    }
                    break;
                case Personal.Achichincle:
                    foreach (Administracion item in administradores)
                    {
                        Console.WriteLine($"achichincles: {item.Nombre}");
                    }
                    break;
                default:
                    break;
            }
        }


    }

    
}
