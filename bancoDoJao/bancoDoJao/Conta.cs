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
        public double limite { get; set; }

        public Conta(int numero, string nome, double limite, double saldo)
        {
            this.numero = numero;
            this.nome = nome;
            this.saldo = saldo;
            this.limite = limite;
        }

        public Conta(int numero, string nome, double limite)
        {
            this.numero = numero;
            this.nome = nome;
            this.limite = limite;
           
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
            if(saldo < valor)
            {
                throw new OperacaoException("Não há saldo suficiente! Saque cancelado.");
            }
            if(valor > limite)
            {
                throw new OperacaoException("Valor do saque é superior ao limite da conta! Saque cancelado.");               

            }
            else
            {
                this.saldo = this.saldo - valor - 5;

            }
        }

    }
}
    

   