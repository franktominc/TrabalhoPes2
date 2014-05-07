using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPES2 {
    class Program {
        static void Main(string[] args) {
            Venda v = new Venda(500.0);
            Desconto dn = new DescontoNatal();
            Desconto dm = new DescontoDiaDasMaes();
            Desconto df = new DescontoFuncionario();
            Desconto de = new DescontoClienteEspecial();
            CalculadoraDeDescontos cd = new CalculadoraDeDescontos();
            cd.Calcula(v, dn);
            cd.Calcula(v, dm);
            cd.Calcula(v, df);
            cd.Calcula(v, de);
            Console.ReadKey();
        }
    }
}
