using SistemaDeDesfazer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDesfazer
{
    public class Pilha
    {
        public string[] Top { get; set; }
        private int contador;
        public int Tamanho { get; set; }

        public Pilha(int tamanho)
        {
            this.Tamanho = tamanho;
            this.Top = new string[tamanho];
            this.contador = 0;
        }

        public bool EstaVazia()
        {
            return this.contador == 0;
        }

        public bool EstaCheia()
        {
            return this.Top[9] != null;
        }

        public void Empilhar(string texto)
        {
            if (EstaCheia())
            {
                Console.WriteLine("A pilha está cheia!");
                Console.ReadKey();
            }
            else
            {
                this.Top[contador] = texto;
                contador++;
            }
        }

        public string Desempilhar()
        {
            if (EstaVazia())
                return null;
            else
            {                                
                string texto = this.Top[contador-1];
                this.contador--;
                return texto;
            }
        }

        public string Topo()
        {
            if (EstaVazia())
                return null;
            else
                return this.Top[contador-1];
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
                Console.WriteLine("A pilha está vazia!");
            else
            {
                int aux = contador - 1;
                for (int i = aux; i >= 0; i--)
                {
                    Console.WriteLine(Top[i]);
                }
            }
        }
    }
}
