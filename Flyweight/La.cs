using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class La : NotaMusical{
        public string Nota { get; private set; }

        public La() {
            Nota = "La";
        }
        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
