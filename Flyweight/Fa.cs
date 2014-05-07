using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Fa : NotaMusical{
        public string Nota { get; private set; }

        public Fa() {
            Nota = "Fa";
        }
        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
