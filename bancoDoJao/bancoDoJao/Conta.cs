using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace bancoDoJao
{
    class Conta
    {
        public int numero { get;}
        public string nome { get; set; }        
        public double saldo { get; private set; }

        public Conta(int numero, string nome, double saldo)
        {
            this.numero = numero;
            this.nome = nome;
            this.saldo = saldo;
        }

        public Conta(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
           
        }

        public override string ToString()
        {
            return 
                "Conta: " + numero
                +", Titular: "
                + nome
                +", Saldo: R$"
                + saldo.ToString("F2",CultureInfo.InvariantCulture)
                ;
        }

        public void deposito(double valor)
        {
            this.saldo = this.saldo + valor;
        }

        public void saque (double valor)
        {
            this.saldo = this.saldo - valor - 5;
        }

    }
}
    

   