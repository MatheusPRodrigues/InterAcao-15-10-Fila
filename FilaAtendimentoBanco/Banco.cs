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

        public Cliente AtenderCliente()
        {
            Cliente clienteParaAtender = new Cliente();

            if (this.FilaNormal.Tamanho() == 0 &&
                this.FilaPrioritaria.Tamanho() == 0)
            {
                this.Contador = 0;
                return null;
            }
            else
            {
                if (this.Contador > 2)
                    this.Contador = 0;

                if (this.Contador == 0)
                {
                    this.Contador++;
                    if (this.FilaPrioritaria.Tamanho() > 0)
                        clienteParaAtender = this.FilaPrioritaria.Desenfileirar();
                    else
                        clienteParaAtender = this.FilaNormal.Desenfileirar();
                }
                else
                {
                    this.Contador++;
                    if (this.FilaNormal.Tamanho() > 0)
                        clienteParaAtender = this.FilaNormal.Desenfileirar();
                    else
                        clienteParaAtender = this.FilaPrioritaria.Desenfileirar();
                }
            }

            return clienteParaAtender;
        }
    }
}
