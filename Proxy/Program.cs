using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy {
    class Program {
        static void Main(string[] args) {

            ProxyText texto1 = new ProxyText("Texto_1");
            ProxyText texto2 = new ProxyText("Texto_2");

            texto1.MostraTexto();
            texto2.MostraTexto();
            Console.ReadKey();
        }
    }

}
