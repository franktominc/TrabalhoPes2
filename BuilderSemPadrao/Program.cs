using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSemPadrao {
    class Program {
        static void Main(string[] args) {
            Pessoa P = new Pessoa("Frank", "12345678","1111111111","1111111111","Rua 123", "X","Y",'M',new DateTime(1994,02,02));
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
