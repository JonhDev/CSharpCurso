﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public float Saldo { get; set; }
        public byte Edad { get; set; }

        public Cliente(string nombre, float saldo, byte edad)
        {
            Nombre = nombre;
            Saldo = saldo;
            Edad = edad;
        }
    }
}