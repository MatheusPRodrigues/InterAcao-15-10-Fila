using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Lista
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }
        public int Contador { get; set; }

        public Lista()
        {
            this.Head = null;
            this.Tail = null;
            this.Contador = 0;
        }

        public bool Vazia()
        {
            return this.Head == null;
        }

        private void InsereInicio(Contato c)
        {
            if (Vazia())
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                // Igual a fila
                c.Proximo = this.Head;
                this.Head = c;
            }
        }

        private void InsereMeio(Contato anterior, Contato proximo, Contato novo)
        {
            anterior.Proximo = novo;
            novo.Proximo = proximo;
        }

        private void InsereFim(Contato c)
        {
            this.Tail.Proximo = c;
            this.Tail = c;
        }

        public void InserirContato(Contato c)
        {
            if (Vazia())
            {
                InsereInicio(c);
            }
            else
            {
                if (String.Compare(c.Nome, this.Head.Nome, StringComparison.Ordinal) < 0)
                {
                    InsereInicio(c);
                }
                else if (String.Compare(c.Nome, this.Tail.Nome, StringComparison.Ordinal) > 0)
                {
                    InsereFim(c);
                }
                else
                {
                    Contato proximo = this.Head.Proximo;
                    Contato anterior = this.Head;

                    while (String.Compare(c.Nome, proximo.Nome, StringComparison.Ordinal) < 0)
                    {
                        anterior = proximo;
                        proximo = proximo.Proximo;
                    }
                    InsereMeio(anterior, proximo, c);
                }
            }
        }

        public void RemoveInicio()
        {

        }

        public void RemoveMeio()
        {

        }

        public void RemoveFim()
        {

        }

        public int Tamanho()
        {
            return this.Contador;
        }

        public void ImprimirLista()
        {

        }
    }
}
