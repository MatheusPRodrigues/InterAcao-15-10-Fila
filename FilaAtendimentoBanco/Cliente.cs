using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaAtendimentoBanco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EhPrioritario { get; set; }
        public Cliente Proximo { get; set; }

        public Cliente(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.EhPrioritario = this.Idade > 59;
            this.Proximo = null;
        }

        public Cliente()
        {
            
        }
    }
}
