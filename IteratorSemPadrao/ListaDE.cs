using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSemPadrao {
    class ListaDE<T> {
        public NoDE<T> Left { get; private set; }

        public NoDE<T> Right { get; private set; }

        public void InsertLeft(T Dado)
        {
            if (Left == null && Right == null)
            {
                Left = Right = new NoDE<T>(null, null, Dado);
            }
            else
            {
                Left = new NoDE<T>(Left, null, Dado);
            }
        }

        public void InsertRight(T Dado)
        {
            if (Left == null && Right == null) {
                Left = Right = new NoDE<T>(null, null, Dado);
            }
            else
            {
                Right = new NoDE<T>(null, Right, Dado);
            }
        }
    }
}
