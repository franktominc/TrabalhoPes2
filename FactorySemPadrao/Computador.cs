using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySemPadrao{
    public class Computador: Eletronico {
        public string Processador { get; private set; }
        public string Memoria { get; private set; }

        public Computador(string processador, string memoria) {
            Processador = processador;
            Memoria = memoria;
        }
        public override string ToString() {
            return "Processador " + Processador + " Memoria " + Memoria;
        }
    }
}
