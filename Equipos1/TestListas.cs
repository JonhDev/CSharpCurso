﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos1
{
    public class TestListas: ManejadorListas
    {
        public List<object> lista = new List<object>();

        public override void Agregar(object obj)
        {
            lista.Add(obj);
        }

        public override object Consultar(int index)
        {
            try
            {
                return lista[index];
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }

        public override bool Eliminar(int index)
        {
            if (index < lista.Count)
            {
                lista.RemoveAt(index);
                return true;
            }
            else return false;
        }

        public void Saluda()
        {
            Console.WriteLine("Saludos");
        }
    }
}
