using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDesfazer
{
    public class Texto
    {
        public string TextoInserido { get; set; }
        public Texto Proximo { get; set; }

        public Texto(string textoInserido)
        {
            this.TextoInserido = textoInserido;
            this.Proximo = null;
        }

        public override string ToString()
        {
            return this.TextoInserido;
        }
    }
}
