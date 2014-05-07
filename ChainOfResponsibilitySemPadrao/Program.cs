using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitySemPadrao {
    class Program {
        static void Main(string[] args) {
            CalculadoraDeImposto C = new CalculadoraDeImposto();
            Console.WriteLine(C.Calcula(2200));
            Console.WriteLine(C.Calcula(800));
            Console.ReadKey();
        }
    }
}
