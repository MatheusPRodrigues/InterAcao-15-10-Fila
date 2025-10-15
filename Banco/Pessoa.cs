using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EhPrioritario { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa (string Nome, int Idade, bool EhPrioritario)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.EhPrioritario = EhPrioritario;
            this.Proximo = null;
        }
    }
}
