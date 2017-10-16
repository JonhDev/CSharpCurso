using System;
using Herencia.Jerarquia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela esc1 = new Escuela("TESE","Ecatepec");
            Estudiante estu1 = new Estudiante();
            estu1.Nombre = "Neto";
            estu1.Matricula = 201010262;
            estu1.Sexo = "Hombre";
            estu1.Carrera = "Anatomia";
            estu1.Edad = 17;

            esc1.Agregar(estu1);

            esc1.Agregar(new Profesor("Pedro") {Edad = 65, Sexo = "Indistinto" });
            esc1.Agregar(new Administracion
            {
                Area = "Calidad",
                Cargo = "Achichincle",
                Sexo = "Hombre",
                Edad = 45,
                Nombre = "Juanito"
            });

            //esc1.Consultar(Personal.Profesor);

            object objeto = new Empleado("Juan");
            Empleado empleado = new Empleado("Raul");

            Empleado test = new Operario("Jose");

            Empleado emple = objeto as Empleado;

            Console.WriteLine(empleado.ToString());

            Operario operario = new Operario("Jose");
            Console.WriteLine(operario.ToString());
            

            Oficial oficial = new Oficial("zacarias");
            Console.WriteLine(oficial.ToString());

            Console.ReadKey();
        }
    }
}
