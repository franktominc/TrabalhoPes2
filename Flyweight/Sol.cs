using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Sol : NotaMusical{
        public string Nota{ get; private set; }

        public Sol() {
            Nota = "Sol";
        }

        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
