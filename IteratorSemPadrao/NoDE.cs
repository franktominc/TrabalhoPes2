using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSemPadrao {
    class NoDE<T> {
        public T Dado{ get; set; }
        public NoDE<T> ProxNoDe;
        public NoDE<T> AntNoDe;

        public NoDE(NoDE<T> proxNoDe = null, NoDE<T> antNoDe = null, T dado = default(T))
        {
            ProxNoDe = proxNoDe;
            AntNoDe = antNoDe;
            this.Dado = dado;
        }

        public override string ToString() {
            return Dado.ToString();
        }
    }
}
