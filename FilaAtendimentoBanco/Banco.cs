using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaAtendimentoBanco
{
    public class Banco
    {
        public Fila FilaNormal { get; set; }
        public Fila FilaPrioritaria { get; set; }
        public int Contador { get; set; }

        public Banco()
        {
            this.FilaNormal = new Fila();
            this.FilaPrioritaria = new Fila();
            this.Contador = 0;
        }

        public Pessoa AtenderCliente()
        {
            if (this.FilaNormal.Tamanho() == 0 &&
                this.FilaPrioritaria.Tamanho() == 0)
                return null;
            else
            {
                if (this.Contador > 2)
                    this.Contador = 0;

                if (this.Contador == 0)
                {
                    this.Contador++;
                    return this.FilaPrioritaria.Desenfileirar();
                }
                else
                {
                    this.Contador++;
                    return this.FilaNormal.Desenfileirar();
                }
            }
        }
    }
}
