using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySemPadrao {
    public class CalculadoraDeImposto {
        public double Calcula(double salario) {
            if(salario < 2*Constantes.SalarioMinimo){
                return salario * 0.05;
            } else if ( salario < 5 * Constantes.SalarioMinimo ) {
                return salario * 0.075;
            } else if ( salario < 10 * Constantes.SalarioMinimo ) {
                return salario * 0.08;
            } else return salario * 0.1;
        }
    }
}
