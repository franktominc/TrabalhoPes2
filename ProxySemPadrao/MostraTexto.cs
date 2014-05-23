using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySemPadrao {
    public class MostraTexto {
        private string NomeArq;
            
        public MostraTexto(string nomearq){
            this.NomeArq = nomearq;
        }

        public void CarregaTexto() {
            Console.WriteLine("carregando o texto " + NomeArq);
        }
        public void ShowTexto(){
            Console.WriteLine("mostrando o texto " + NomeArq);
        }
    }
}
