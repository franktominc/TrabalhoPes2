using System;

namespace FlyweightSemPadrao {
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
