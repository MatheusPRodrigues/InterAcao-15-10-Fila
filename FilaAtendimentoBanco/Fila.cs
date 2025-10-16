using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaAtendimentoBanco
{
    public class Fila
    {
        private Cliente head;
        private Cliente tail;

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

        public void Enfileirar(Cliente c)
        {
            if (FilaVazia())
            {
                this.head = c;
                this.tail = c;
            }
            else
            {
                this.tail.Proximo = c;
                this.tail = c;
            }
        }

        public Cliente Desenfileirar()
        {
            if (FilaVazia())
                return null;
            else
            {
                Cliente clienteParaSerRemovida = this.head;
                this.head = this.head.Proximo;

                if (this.head == null)
                    this.tail = null;

                return clienteParaSerRemovida;
            }
        }

        public void MostrarFila()
        {
            if (FilaVazia())
                Console.WriteLine("Fila está vazia!");
            else
            {
                Cliente aux = this.head;
                while (aux != null)
                {
                    Console.WriteLine($"Nome: {aux.Nome}");
                    Console.WriteLine($"Idade: {aux.Idade}");
                    if (aux.EhPrioritario)
                        Console.WriteLine("Cliente prioritário!");
                    else
                        Console.WriteLine("Cliente normal!");

                    Console.WriteLine();

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
                Cliente aux = this.head;
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
