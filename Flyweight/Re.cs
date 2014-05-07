using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Re : NotaMusical {
        public string Nota { get; private set; }

        public Re() {
            Nota = "Re";
        }
        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
