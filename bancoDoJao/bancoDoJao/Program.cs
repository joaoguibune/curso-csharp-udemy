using System;
using System.Globalization;

namespace bancoDoJao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta C;
            double valor;
            double saldo = 0;

           

            Console.WriteLine("Bem, vindo ao banco do Jão");
            Console.WriteLine("Criar Nova Conta");
            Console.Write("Digite o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta:");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char deposito = char.Parse(Console.ReadLine());
            if(deposito == 's')
            {
                Console.Write("Digite o valor do depósito inicial:");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

            }

            C = new Conta(numero, nome, saldo);


            Console.WriteLine("Conta Criada");
            Console.WriteLine(C);

            Console.WriteLine("Digite um valor para depósito");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C.deposito(valor);
            Console.WriteLine("Conta Atualizada");
            Console.WriteLine(C);

            Console.WriteLine("Digite um valor para saque");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C.saque(valor);
            Console.WriteLine("Conta Atualizada");
            Console.WriteLine(C);

            Console.ReadLine();


        }
    }
}
