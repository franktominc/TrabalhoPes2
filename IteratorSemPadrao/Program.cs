using System;

namespace IteratorSemPadrao {
    public class Program {
 

        static void Main() {
            var lista = new ListaDE<int>();
            lista.InsertLeft(10);
            lista.InsertLeft(20);
            lista.InsertLeft(30);
            NoDE<int> aux = lista.Left;
            while (aux != null) {
                Console.WriteLine(aux);
                aux = aux.ProxNoDe;
            }
            Console.ReadKey();
        }
    }

    
}
