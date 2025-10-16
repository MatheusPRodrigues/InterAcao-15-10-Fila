using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto
{
    public class Pilha
    {
        private Texto top;
        private int contador;
        public int Tamanho { get; set; }

        public Pilha(int tamanho)
        {
            this.top = null;
            this.Tamanho = tamanho;
            this.contador = -1;
        }

        public bool EstaVazia()
        {
            return this.top == null;
        }

        public bool EstaCheia()
        {
            return contador == (this.Tamanho - 1);
        }

        public void Empilhar(Texto t)
        {
            if (EstaCheia())
                Console.WriteLine("A pilha está cheia!");
            else
            {
                if (EstaVazia() )
                {
                    this.top = t;
                    Tamanho = 0;
                }
                else
                {
                    t.Proximo = this.top;
                    this.top = t;
                    this.contador++;
                }
            }            
        }

        public Texto Desempilhar()
        {
            if (EstaVazia())
                return null;
            else
            {
                Texto texto = this.top;
                this.top = this.top.Proximo;
                this.contador--;
                return texto;   
            }
        }

        public Texto Topo()
        {
            if (EstaVazia())
                return null;
            else
                return this.top;
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
                Console.WriteLine("A pilha está vazia!");
            else
            {
                Texto texto = this.top;

                while (texto != null)
                {
                    Console.WriteLine(texto.ToString() + "\n");
                    texto = texto.Proximo;
                }
            }
        }
    }
}
