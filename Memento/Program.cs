using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    class Program {
        static void Main(string[] args) {
            Objeto objeto = new Objeto();
            objeto.MudaEstado(new Estado1());
            objeto.MudaEstado(new Estado2());
            objeto.MudaEstado(new Estado3());
            Console.WriteLine("Estado Atual "+ objeto.EstadoAtual);
            objeto.VoltaEstado();
            objeto.VoltaEstado();
            objeto.VoltaEstado();
            objeto.VoltaEstado();
            Console.ReadKey();
        }
    }
}
