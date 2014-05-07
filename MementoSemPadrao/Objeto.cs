using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSemPadrao {
    public class Objeto {
        public Estado EstadoAtual { get; set; }
        public void MudaEstado(Estado NovoEstado) {
            EstadoAtual = NovoEstado;
        }
    }
}
