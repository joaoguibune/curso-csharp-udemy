namespace figuras
{
    abstract class Figura
    {
       public Cor cor { get; set; }

        public Figura(Cor cor)
        {
            this.cor = cor;
        }
        public abstract double area();

        public abstract double perimetro();



    }
}
