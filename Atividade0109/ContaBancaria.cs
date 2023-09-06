using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class ContaBancaria
    {
        public string nomtitular;
        public string Nconta;
        public string Nagencia;
        public string nomebanco;

        private double Saldos;

        public double Saldo
        {
            get
            {
                return this.Saldo;
            }
            set
            {
                this.Saldo = value;
            }
        }

        public void Sacar(double ValorDoSaque)
        {
            if (ValorDoSaque > Saldo)
            {
                Console.WriteLine("voce não possui saldo suficiente para obter um saque");
                Console.ReadKey();
            }
            else if (ValorDoSaque < Saldo || ValorDoSaque == Saldo)
            {
                double calcularValorSaldo = Saldo - ValorDoSaque;
                Console.WriteLine("o valor do saque foi de " + ValorDoSaque);
                Console.WriteLine("o valor do seu saldo ficou em " +  calcularValorSaldo);
                Console.ReadKey();
            }
        }
        public void Depositar(double ValorDoDeposito)
        {
            this.Saldo = ValorDoDeposito;
        }
    }

}

