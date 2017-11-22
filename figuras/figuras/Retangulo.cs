using System;
using System.Collections.Generic;
using System.Text;

namespace figuras
{
    class Retangulo : Figura
    {

        public double b { get; set; }
        public double h { get; set; }

        public Retangulo(double b, double h, Cor cor):base(cor)
        {
            this.b = b;
            this.h = h;
        }


        public override double area()
        {
            return b * h;
        }

        public override double perimetro()
        {
            return 2 * (b + h);
        }
    }
}
