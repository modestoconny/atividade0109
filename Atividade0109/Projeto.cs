using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Projeto : Estudante
    {
        public int DataParaProjeto { get; set; }
        
        public void EscolherProfissão()
        {
            Console.WriteLine("qual profissao gostaria de escolher?");
            string profissao= Convert.ToString(Console.ReadLine());

            Console.WriteLine("qual faculdade gostaria de estudar?");
            string faculdade = Convert.ToString(Console.ReadLine());

            Console.WriteLine("citar 3 coisas que gostaria de estar fazendo daqui a 5 anos");
            string fazer = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string ensinomedio = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Citar 3 características de quais são os seus projetos para o futuro?");
            string caracteristica = Convert.ToString(Console.ReadLine());

            Console.WriteLine("quais foram suas escolhas " + profissao + "sua profissao" + faculdade +
                "sua faculdade" + caracteristica + "seus projetos foram");

          

        }
    }
}
