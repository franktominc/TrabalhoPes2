using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactorySemPadrao {
    class Program {
        static void Main(string[] args) {
            Eletronico Computador = new Computador("I7", "8GB");
            Console.WriteLine(Computador);
            Eletronico Calculadora = new Calculadora(15);
            Console.WriteLine(Calculadora);
            Eletronico Notebook = new Notebook("I7", "6GB", "15 Polegadas");
            Console.WriteLine(Notebook);
            Console.ReadKey();
        }
    }
}
