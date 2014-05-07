using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoProjeto {
    public class ImpostoAcimaDe10SM : Imposto {
        public Imposto Proximo { get; set; }

        public double Calcula(double Salario) {
                return Salario * 0.1;
        }
    }
}
