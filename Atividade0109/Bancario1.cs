using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Bancario1 : Colaborador1
    {
        public override void CalcularExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mes corrente");
            double he= Convert.ToDouble(Console.ReadLine());

            double result = he*250;

            if(he > 500)
            {
                double result1 = result*0.1;
                Console.WriteLine("o novo valor das horas extras");
            }
            else if(he > 1000)
            {
                double result2 = result*0.15;
                Console.WriteLine("o novo valor das horas extras");
            }

            else
            {
                Console.WriteLine("o valor final das extras é"+ result);
            }
        }
        
    }
}
