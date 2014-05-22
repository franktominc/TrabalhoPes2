using System;

namespace FlyweightSemPadrao {
    public class Re : NotaMusical {
        public string Nota { get; private set; }

        public Re() {
            Nota = "Re";
        }
        public void toca() {
            Console.WriteLine(Nota + " ");
        }
    }
}
