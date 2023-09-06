using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Desenvolvedor1 : Colaborador1
    {
        public override void CalcularExtras()
        
          
        {
            Console.WriteLine("digite a sua  modealidade de traalho A- Presencial, B-Hibrido e C-Remoto;");
            string modalidade = Convert.ToString(Console.ReadLine());

            if (modalidade == "a")
            {
                Console.WriteLine("digite a quantidade de horas extras q o trabalhador possui");
                double h = Convert.ToDouble(Console.ReadLine());
                double result = h * 100;
                Console.WriteLine("o total de horas é" + result);
            }
            else if (modalidade == "b")
            {
                Console.WriteLine("digite a quantidade de horas extras q o trabalhador possui");
                double h = Convert.ToDouble(Console.ReadLine());
                double result = h * 50;
                Console.WriteLine("o total de horas é" + result);
            }
            else if (modalidade == "c")
            {
                Console.WriteLine("o seu horario é flexivel, ou seja,voce escolhe seu horario de trabalho, entao nao completa a hora extra");
            }
            else
            {
                Console.WriteLine("voce digitou uma opçao invalida");
            }
        }
    }
}
