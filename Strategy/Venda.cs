using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPES2 {
    public class Venda {
        public double Valor { get; private set; }
        public Venda(double valor) {
            Valor = valor;
        }
    }
}
