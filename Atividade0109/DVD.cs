using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class DVD
    {
        private int filme;
        public string filmee 
        {
            get
            {
                return this.filmee;
            }
            set
            {
                this.filmee = value;
            }
        }

        public virtual void VerFilmes()
        {
            Console.WriteLine("digite dois filmes que gosta de assistir? ");
            string filme = Convert.ToString(Console.ReadLine());
            Console.WriteLine("qual o gênero dos filmes ");
            string genero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("seu ano de lançamento");
            string lancamento = Convert.ToString(Console.ReadLine());

            Console.WriteLine("seu filme favorito é" + filme);
            Console.WriteLine("o genero desse filme é " + genero);
            Console.WriteLine("seu lançamento foi" +lancamento);
        }
        

    }
}
