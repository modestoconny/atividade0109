using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    internal class GerenteTI : Colaborador1
    {
        public override void CalcularExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mes corrente");
            double hora = Convert.ToDouble(Console.ReadLine());

            double ex = hora / 2;

            if (hora > 100) 
            {
                double result = (hora/2) * 200 + 500;
                double dias = result / 8;
                Console.WriteLine("o total de horas extras sera de " + result);
               
            }
            else
            {
                double result = hora + 400;
                Console.WriteLine("o total de horas extras sera de " + result);
            }

        }
    }
}
