using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class USB
    {
        private string Musicas;

        public string musica
        {
            get
            {
                return this.Musicas;
            }
            set
            {
                this.Musicas = value;
            }
        }


        private string CapacidadeArmazenamento;
        public string Armazenamento
        {
            get
            {
                return this.CapacidadeArmazenamento;
            }
            set
            {
                this.CapacidadeArmazenamento = value;
            }
        }


        public void LerMusicas()
        {

            Console.WriteLine("é possíveis salvar 600 músicas de 8 MB em um pendrive de 5 GB");
            Console.WriteLine(" digite 5 músicas que gosta de ouvir e tambem o nome da música e o cantor");
            string Musica00 = Console.ReadLine();
            string Musica01 = Console.ReadLine();
            string Musica02 = Console.ReadLine();
            string Musica03 = Console.ReadLine();
            string Musica04 = Console.ReadLine();
            Console.WriteLine("As Informaçoes são: "+ Musica00);
            Console.WriteLine("As Informaçoes são: "+ Musica01);
            Console.WriteLine("As Informaçoes são: "+ Musica03);
            Console.WriteLine("As Informaçoes são: "+ Musica04);
           
            Console.ReadKey();


        }
    }
}
    
