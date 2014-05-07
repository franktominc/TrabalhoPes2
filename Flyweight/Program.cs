using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    class Program {
        static void Main(string[] args) {
            LinkedList<NotaMusical> Musica = new LinkedList<NotaMusical>();
            PoolDeNotas pool = new PoolDeNotas();
            Musica.AddLast(pool.getNota("Do"));
            Musica.AddLast(pool.getNota("Re"));
            Musica.AddLast(pool.getNota("Mi"));
            Musica.AddLast(pool.getNota("Fa"));
            foreach ( var nota in Musica ) {
                nota.toca();
            }
            Console.ReadKey();
        }
    }
}
