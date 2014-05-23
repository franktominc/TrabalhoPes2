using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    public class List : IList {
        public NoDE Start { get;private set; }
        public IIterator GetIterator() {
            return new ListIterator(this);
        }

        public void insert(int dado) {
            Start = new NoDE(Start,null, dado);
        }
    }

    class ListIterator : IIterator {
        private NoDE currentNoDe;

        public ListIterator(List list) {
            currentNoDe = list.Start;
        }

        public bool HasNext() {
            return currentNoDe != null;
        }

        public object Next() {
            if (HasNext()) {
                int aux = currentNoDe.Dado;
                currentNoDe = currentNoDe.ProxNoDe;
                return aux;
            }
            return null;
        }
    }
}
