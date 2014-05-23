using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySemPadrao {
    class Program {
        static void Main(string[] args) {
            MostraTexto text1 = new MostraTexto("Texto 1");
            MostraTexto text2 = new MostraTexto("Texto 2");

            text1.CarregaTexto();
            text2.CarregaTexto();
            text1.ShowTexto();
            text2.ShowTexto();

            Console.ReadKey();
        }
    }
}
