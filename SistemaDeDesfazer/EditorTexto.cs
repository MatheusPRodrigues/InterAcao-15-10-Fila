using SistemaDeDesfazer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDesfazer
{
    public class EditorTexto
    {
        public Pilha Historico { get; set; }

        public void Digitar(string t)
        {
            this.Historico.Empilhar(t);
        }

        public string Desfazer()
        {
            return this.Historico.Desempilhar();
        }

        public void MostrarHistorico()
        {
            this.Historico.ExibirPilha();
        }
    }
}
