using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaManual
{
    public class Fila
    {
        private Pessoa head;
        private Pessoa tail;

        public Fila()
        {
            this.head = null;
            this.tail = head;
        }

        public bool FilaVazia()
        {
            if (this.head == null)
                return true;
            else
                return false;
        }

        public void InserirPessoa(Pessoa elemento)
        {
            if (FilaVazia())
            {
                head = elemento;
                tail = elemento;
            }
            else
            {
                tail.Proximo = elemento;
                tail = elemento;
            }
        }

        public bool RemoverPessoa()
        {
            if (FilaVazia())
                return false;
            else
            {
                this.head = this.head.Proximo;

                if (this.head == null)
                    this.tail = null;

                return true;
            }
        }

        public Pessoa PrimeiraPosicao()
        {
            if (FilaVazia())
                return null;
            else
            {
                Pessoa primeiraPosicao = this.head;
                return primeiraPosicao;
            }
        }

        public int TamanhoFila()
        {
            int contador = 0;
            if (FilaVazia())
                return contador;
            else
            {
                Pessoa aux = this.head;
                do
                {
                    contador++;
                    aux = aux.Proximo;
                }
                while (aux != null);

                return contador;
            }
        }

        public void ImprimirFila()
        {
            if (FilaVazia())
                Console.WriteLine("Fila Vazia!");
            else
            {
                Pessoa aux = this.head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
