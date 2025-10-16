using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaAtendimentoBanco
{
    public class Fila
    {
        private Pessoa head;
        private Pessoa tail;

        public Fila()
        {
            this.head = null;
            this.tail = null;
        }

        public bool FilaVazia()
        {
            if (this.head == null)
                return true;
            else
                return false;
        }

        public void Enfileirar(Pessoa pessoaParaInserir)
        {
            if (FilaVazia())
            {
                this.head = pessoaParaInserir;
                this.tail = pessoaParaInserir;
            }
            else
            {
                tail.Proximo = pessoaParaInserir;
                tail = pessoaParaInserir;
            }
        }

        public Pessoa Desenfileirar()
        {
            if (FilaVazia())
                return null;
            else
            {
                Pessoa pessoaParaSerRemovida = this.head;
                this.head = this.head.Proximo;

                if (this.head == null)
                    this.tail = null;

                return pessoaParaSerRemovida;
            }
        }

        public void MostrarFila()
        {
            if (FilaVazia())
                Console.WriteLine("Fila está vazia!");
            else
            {
                Pessoa aux = head;
                while (aux != null)
                {
                    Console.WriteLine($"Nome: {aux.Nome}");
                    Console.WriteLine($"Idade: {aux.Idade}");
                    if (aux.EhPrioritario)
                        Console.WriteLine("Cliente prioritário!");
                    else
                        Console.WriteLine("Cliente normal!");

                    aux = aux.Proximo;
                }
            }
        }

        public int Tamanho()
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
    }
}
