using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDeRoupas
{
    public class Pilha
    {
        private Roupa top;

        public Pilha()
        {
            this.top = null;
        }

        public bool Vazio()
        {
            return this.top == null;
        }

        public void Empilhar(Roupa r)
        {
            if (Vazio())
            {
                this.top = r;
            }
            else
            {
                r.Proximo = this.top;
                this.top = r;
            }
        }

        public Roupa Desempilhar()
        {
            if (Vazio())
            {
                return null;
            }
            else
            {
                Roupa roupa = this.top;
                this.top = top.Proximo;

                return roupa;
            }
        }

        public void ExibirPilha()
        {
            if (Vazio())
            {
                Console.WriteLine("Pilha vazia!");
            } else
            {
                Roupa r = this.top;
                
                while (r != null)
                {
                    Console.WriteLine(r.ToString() + "\n");
                    r = r.Proximo;
                }
            }
        }
    }
}
