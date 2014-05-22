using System;

namespace FlyweightSemPadrao {
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
