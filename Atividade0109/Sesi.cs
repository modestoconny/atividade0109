using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Sesi
    {
        public static void CaucularMedia()
        {
           Console.WriteLine("digite suas 1 notas: ");
           double media = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("digite suas 2 notas: ");
           double media2 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("digite suas 3 notas: ");
           double media3 = Convert.ToInt32(Console.ReadLine());


            {
                if (media >= 7)
                {
                    Console.WriteLine("o aluno foi aprovado");
                }
                else if (media <= 5)
                {
                    Console.WriteLine("o aluno foi para a recuperaçao");
                }
                else 
                {
                    Console.WriteLine("o aluno foi reprovado");
                }

            }

            
        }

    }
}
