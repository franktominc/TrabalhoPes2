using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPES2 {
    public class DescontoDiaDasMaes : Desconto{
        public double CalculaDesconto(Venda v) {
            return v.Valor * 0.07;
        }
    }
}
