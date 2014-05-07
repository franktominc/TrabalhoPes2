using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    public static class EletronicosFactory {
        public static Eletronico getEletronico(string eletronico) {
            switch (eletronico) {
                case "Computador":
                    return new Computador("I7", "8GB");
                case "Notebook":
                    return new Notebook("I5", "6GB", "15 polegadas");
                case "Calculadora":
                    return new Calculadora(15);
            }
            return null;
        }
    }
}
