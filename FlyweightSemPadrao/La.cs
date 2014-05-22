using System;

namespace FlyweightSemPadrao {
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
