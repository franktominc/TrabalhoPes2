using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Mi : NotaMusical{

        public string Nota { get; private set ; }

        public Mi() {
            Nota = "Mi";
        }

        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
