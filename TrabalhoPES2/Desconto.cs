using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPES2 {
    public interface Desconto {
        double CalculaDesconto(Venda v);
    }
}
