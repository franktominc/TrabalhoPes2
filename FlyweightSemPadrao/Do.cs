using System;

namespace FlyweightSemPadrao {
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
