using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Midia
    {
        private int codigo;
        private string nome;
        private double preco;

        public int Codigoo
        {
            get
            {
                return this.Codigoo;
            }
            set
            {
                this.Codigoo = value;
            }
        }

        public int Nomee
        {
            get
            {
                return this.Nomee;

            }
            set
            {
                this.Nomee = value;
            }
        }
        public int Precoo
        {
            get
            {
                return this.Precoo;
            }
            set
            {
                this.Precoo = value;
            }
        }
        public virtual void ImprimirDados()
        {
            Console.WriteLine("nome do cantor favorito, o nome da música e o ano do seu lançamento");
            string cantor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite o nome da música ");
            string nomedamusic = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite o lançamento da música ");
            string lancamento = Convert.ToString(Console.ReadLine());

            Console.WriteLine("seu cantor favorito é" +cantor);
            Console.WriteLine("o nome da musica  é" +nomedamusic);
            Console.WriteLine("seu lançamento foi" +lancamento);







        }

    }
}
