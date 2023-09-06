using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade0109
{
    class Gato: Animal
    {
        private string CorPelo;

        public string Pelo
        {
            get
            {
                return this.CorPelo;
            }

            set
            {
                this.CorPelo = value;
            }
        }
    }
}
