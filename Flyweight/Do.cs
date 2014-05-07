using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class Do:NotaMusical {
        public string Nota { get; private set; }
        public Do() {
            Nota = "Do"; 
        }
        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
