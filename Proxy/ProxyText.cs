using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy {
    public class ProxyText {
        private ArquivoTexto texto = null;
        private string NomeArquivo = null;

        public ProxyText(string nomearquivo) {
            this.NomeArquivo = nomearquivo;
        }

        public void MostraTexto() {
            if ( texto == null ) {
                texto = new ArquivoTexto(NomeArquivo);
            }
            texto.AbreTexto();
            texto.MostraTexto();
        }
    }
}
