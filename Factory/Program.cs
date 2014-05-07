using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args){
            Eletronico el = EletronicosFactory.getEletronico("Computador");
            Console.WriteLine(el);
            el = EletronicosFactory.getEletronico("Notebook");
            Console.WriteLine(el);
            el = EletronicosFactory.getEletronico("Calculadora");
            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
