using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPES2 {
    public class CalculadoraDeDescontos {
        public void Calcula(Venda v, Desconto d) {
            Console.WriteLine(d.CalculaDesconto(v));
        }
    }
}
