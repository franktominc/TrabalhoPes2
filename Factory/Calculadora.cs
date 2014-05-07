using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    public class Calculadora : Eletronico{
        public int QuantidadeDeDigitos { get; private set; }

        public Calculadora(int quantidadeDeDigitos) {
            QuantidadeDeDigitos = quantidadeDeDigitos;
        }

        public override string ToString() {
            return "Quantidade de digitos " + QuantidadeDeDigitos;
        }
    }
}
