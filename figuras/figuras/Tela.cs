﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace figuras
{
    class Tela
    {
        public static Retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Retangulo(largura, altura,Cor.Vermelho);
        }

        public static Triangulo lerTriangulo()
        {

            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Triangulo(a, b, c, Cor.Azul);
        }
    }
}
