using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Senai
    {
        public static void CaucularMedia()
        {
            Console.WriteLine("digite sua primeira nota de 0 a 100: ");
            double media1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua segunda nota de 0 a 100: ");
            double media2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua terceira nota de 0 a 100:");
            double media3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua quarta nota de 0 a 100:");
            double media4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua frequencia:");
            double fequencia = Convert.ToInt32(Console.ReadLine());

            double media = (media1 +media2 + media3 + media4) / 4;
            {
                if (media >= 7 && fequencia >=90)
                {
                    Console.WriteLine("o aluno foi aprovado no curso tecnico");
                }
                else if (media >=70 && fequencia >= 90)
                {
                    Console.WriteLine("o aluno foi para a recuperaçao");
                }
                else if (media >= 7 && fequencia <90)
                {
                    Console.WriteLine("o aluno foi reprovado por falta");
                }

                else
                {
                    Console.WriteLine("aluno reprovado");
                }

            }
                

            



        }
    }
}
