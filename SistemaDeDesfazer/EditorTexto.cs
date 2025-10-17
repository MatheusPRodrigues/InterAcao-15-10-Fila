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
        public Pilha Textos { get; set; }
        public Pilha Historico { get; set; } = new Pilha();

        public void Digitar(string t)
        {
            Texto texto = new Texto(t);
            this.Textos.Empilhar(texto);
            this.Historico.Empilhar(texto);
        }

        public Texto Desfazer()
        {
            Texto desfazerAcao =  this.Textos.Desempilhar();
            desfazerAcao.Proximo = null;
            this.Historico.Empilhar(desfazerAcao);
            return desfazerAcao;
        }

        public void MostrarHistorico()
        {
            this.Historico.ExibirPilha();
        }
    }
}
