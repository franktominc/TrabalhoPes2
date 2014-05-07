using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoProjeto {
    public interface Imposto {
        Imposto Proximo { get; set; }
        double Calcula(double Salario);
    }
}
