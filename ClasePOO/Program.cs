using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    class Program
    {
        static Stack<int> t1 = new Stack<int>();
        static Stack<int> t2 = new Stack<int>();
        static Stack<int> t3 = new Stack<int>();
        static Queue<int> t = new Queue<int>();

        static void Main(string[] args)
        {
            Banco b = new Banco();
            b.Nombre = "Banco 1";
            b.ImprimirSaldos();
            b.DepositarSaldo(100000.0f, "Juan");
            b.ImprimirSaldos();
            Torres(3, 0);
            Console.ReadKey();  
            

        }

        static int Torres(int piezas, int movimientos)
        {
            if(movimientos == 0)
            {
                for (int i = 0; i < piezas; i++)
                    t.Enqueue(i);
            }

            t3.Push(t1.Pop());
            t2.Push(t1.Pop());
            t2.Push(t3.Pop());
            t3.Push(t1.Pop());
            t1.Push(t2.Pop());
            t3.Push(t2.Pop());
            t3.Push(t1.Pop());
            return 0;
        }
    }
}
