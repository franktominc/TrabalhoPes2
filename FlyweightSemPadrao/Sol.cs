using System;

namespace FlyweightSemPadrao {
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
