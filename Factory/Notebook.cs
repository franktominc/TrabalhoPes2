using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    public class Notebook : Eletronico{
        public string Processador { get; private set; }
        public string Memoria { get; private set; }
        public string TamanhoDaTela { get; private set; }

        public Notebook(string processador, string memoria, string tamanhoDaTela) {
            Processador = processador;
            Memoria = memoria;
            TamanhoDaTela = tamanhoDaTela;
        }
        public override string ToString() {
            return "Processador " + Processador + 
                " Memoria " + Memoria + " Tamanho Da Tela " + TamanhoDaTela;
        }
    }
}
