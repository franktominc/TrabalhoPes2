using System;

namespace FlyweightSemPadrao {
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
