using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaManual
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa()
        {
            this.Proximo = null;
        }
    }
}
