using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Losango : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("digite o lado losangulo");
            int lado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a altura do losangulo");
            int altura =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" as infomacoes sao " + lado + altura);

            int result =lado*altura;
            Console.WriteLine(result);



        }
    }
}
