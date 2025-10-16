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
            Texto texto = new Texto(t);
            this.Historico.Empilhar(texto);
        }

        public Texto Desfazer()
        {
            return this.Historico.Desempilhar();
        }

        public void MostrarHistorico()
        {
            this.Historico.ExibirPilha();
        }
    }
}
