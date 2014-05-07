using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySemPadrao {
    public class CalculadoraDeDescontos {
        public double AplicaDescontoDiaDasMaes(Venda v) {
            return v.Valor * 0.07;
        }
        public double AplicaDescontoClienteEspecial(Venda v) {
            return v.Valor * 0.1;
        }
        public double AplicaDescontoFuncionario(Venda v) {
            return v.Valor * 0.2;
        }
        public double AplicaDescontoNatal(Venda v) {
            return v.Valor * 0.05;
        }
    }
}
