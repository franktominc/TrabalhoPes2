using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy {
    public class ArquivoTexto : Texto {
        private string NomeArquivo = null;
        public ArquivoTexto(string filename) {
            this.NomeArquivo = filename;
            AbreTexto();
        }

        public void AbreTexto() {
            Console.WriteLine("Abrindo " + NomeArquivo);
        }

        public void MostraTexto() {
            Console.WriteLine("Mostrando " + NomeArquivo);
        }


        
    }
}
