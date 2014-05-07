using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSemPadrao {
    class Program {
        static void Main(string[] args) {
            Objeto objeto = new Objeto();
            Stack<Estado> estados = new Stack<Estado>();
            Console.WriteLine("Mudando para estado 1");
            objeto.MudaEstado(new Estado1());
            estados.Push(new Estado1());
            Console.WriteLine("Mudando Para estado 2");
            objeto.MudaEstado(new Estado2());
            estados.Push(new Estado2());
            estados.Pop();
            Console.WriteLine("Voltando para estado 1");
            objeto.EstadoAtual = estados.Peek();
            Console.ReadKey();

        }
    }
}
