using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Retangulo : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("digite o base losangulo");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a altura do losangulo");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" as infomacoes sao " + Base + altura);

            int result = Base*altura;
            Console.WriteLine(result);



        }
    }
}
