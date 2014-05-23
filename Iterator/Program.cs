using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class Program {
        static void Main(String[] Args) {
            List list = new List();
            list.insert(10);
            list.insert(20);
            list.insert(30);
            IIterator it = list.GetIterator();
            while (it.HasNext()) {
                Console.WriteLine(it.Next());
            }
            Console.ReadKey();
        }
    }
}
