using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade {
    class Program {
        static void Main(string[] args) {
            BDFacade BD = BDFacade.getInstance();
            BD.ConectaMySQL();
            BD.ConectaOracle();
            BD.ConectaPostGre();
            Console.WriteLine(BD.GetHashCode());
            BD = BDFacade.getInstance();
            Console.WriteLine(BD.GetHashCode());
            Console.ReadKey();
        }
    }
}
