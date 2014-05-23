using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoProjeto {
    class Program {
        static void Main(string[] args) {
            double s1 = 900, s2 = 2000, s3 = 5000, s4 = 9000;
            CalculadoraDeImposto ci = new CalculadoraDeImposto();
            ci.Calcula(s1);
            ci.Calcula(s2);
            ci.Calcula(s3);
            ci.Calcula(s4);
            Console.ReadKey();
        }
    }
}
