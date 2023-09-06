using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Escola
    {
        public static void CaucularMedia()
        {

        }

        public static void DescobrirNome()
        {
            Console.WriteLine("digite qual escola vc estuda: ");
            string escola = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite sua cidade");
            string cidade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite qual seu estado");
            string estado = Convert.ToString(Console.ReadLine());
          
            if (escola== "sesi/senai" && cidade =="garça") 
            {
                Console.WriteLine("aluno sesi/aluno senai" );
            }

            else
            {
                Console.WriteLine("a escola que vc estuda é: " + escola + "  a cidade que vc mora é: " +cidade);

            }



          
        }
    }
}
