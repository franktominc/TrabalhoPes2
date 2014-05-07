using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySemPadrao {
    class Program {
        static void Main(string[] args) {
            Venda v = new Venda(500);
            CalculadoraDeDescontos calc = new CalculadoraDeDescontos();
            Console.WriteLine(calc.AplicaDescontoClienteEspecial(v));
            Console.WriteLine(calc.AplicaDescontoDiaDasMaes(v));
            Console.WriteLine(calc.AplicaDescontoFuncionario(v));
            Console.WriteLine(calc.AplicaDescontoNatal(v));
        }
    }
}
