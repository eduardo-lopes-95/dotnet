﻿using System;
using Classes.Heranca;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto3D p2 = new Ponto3D(10, 20, 30);
            p2.CalcularDistancia3();
        }
    }
}
