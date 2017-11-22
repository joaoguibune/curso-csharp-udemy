using System;
using System.Globalization;

namespace alturaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int N;
            double total = 0;

            Console.Write("Insira a quantidade de valores:");
            N = int.Parse(Console.ReadLine());

            vet = new double[N];

            for (int i=0; i<N; i++)
            {
                Console.Write("Insira a altura: ");
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                total = total + vet[i];
            }

            Console.Write("Média das alturas: " + (total/N).ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
