using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSemPadrao {
    class Program {
        static void Main(string[] args)
        {
            ICollection<NotaMusical> musicals = new LinkedList<NotaMusical>();

            musicals.Add(new Do());
            musicals.Add(new Fa());
            musicals.Add(new La());
            musicals.Add(new Re());
            foreach (var notaMusical in musicals){
                notaMusical.toca();
            }
            Console.ReadKey();
        }
    }
}
