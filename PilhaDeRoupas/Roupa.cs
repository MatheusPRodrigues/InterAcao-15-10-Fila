using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDeRoupas
{
    public class Roupa
    {
        public string Categoria { get; set; }
        public string Cor { get; set; }
        public Roupa Proximo { get; set; }

        public Roupa()
        {
            this.Proximo = null;
        }

        public override string ToString()
        {
            return $"Categoria: {this.Categoria}\n" +
                $"Cor: {this.Cor}";
        }
    }
}
