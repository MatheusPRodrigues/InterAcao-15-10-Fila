using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Contato Proximo { get; set; }

        public Contato()
        {
            this.Proximo = null;
        }
    }
}
