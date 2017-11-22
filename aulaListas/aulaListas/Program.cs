using System;
using System.Collections.Generic;

namespace aulaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("João");
            lista.Add("Mariana");
            lista.Add("Ana");
            lista.Add("José");

            int pos = lista.FindIndex(x => x == "Mariana");

            Console.WriteLine(pos);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
