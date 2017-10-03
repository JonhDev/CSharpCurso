using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    public class Banco
    {
        public string Nombre { get; set; }

        Cliente[] clientes =
            {
                new Cliente("Juan", 1234.3f, 20),
                new Cliente("Raul", 4321.5f, 30),
                new Cliente("Alex", 3245.2f, 19),
                new Cliente("Javier", 7245.2f, 21),
                new Cliente("Fernando", 2745.2f, 49)
            };

        public void DepositarSaldo(float deposito, string cliente)
        {
            foreach (Cliente item in clientes)
            {
                if (item.Nombre == cliente)
                    item.Saldo += deposito;
            }
        }

        public void ImprimirSaldos()
        {
            Console.WriteLine($"------------ {Nombre} ------------");
            foreach (Cliente item in clientes)
                Console.WriteLine($"{item.Nombre} tiene un saldo actual de {item.Saldo}");
        }

    }
}
