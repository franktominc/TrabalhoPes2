using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    public class Objeto {
        private Stack<Estado> Estados = new Stack<Estado>();
        public Estado EstadoAtual { get; private set; }
        public void MudaEstado(Estado novoEstado) {
            Estados.Push(novoEstado);
            EstadoAtual = novoEstado;
        }
        public void VoltaEstado() {
            if (!(Estados.Count == 0)) {
                Console.WriteLine("Voltando para o estado " + Estados.Peek());
                EstadoAtual = Estados.Peek();
                Estados.Pop();
            } else {
                Console.WriteLine("Não existe estado anterior");
            }
        }
    }
}
