using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoProjeto {
    public class ImpostoAbaixoDe10SM : Imposto {
        public Imposto Proximo { get; set; }

        public double Calcula(double Salario) {
            if ( Salario < 10 * Constantes.SalarioMinimo ) {
                return Salario * 0.08;
            }
            return Proximo.Calcula(Salario);
        }
    }
}
