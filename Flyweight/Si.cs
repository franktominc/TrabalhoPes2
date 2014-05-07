using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Si : NotaMusical{
        public string Nota { get; private set; }

        public Si() {
            Nota = "Si";
        }

        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
