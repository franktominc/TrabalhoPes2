using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoProjeto {
    public class CalculadoraDeImposto {
        public void Calcula(double Salario) {
            Imposto I2 = new ImpostoAbaixoDe2SM();
            Imposto I5 = new ImpostoAbaixoDe5SM();
            Imposto I10 = new ImpostoAbaixoDe10SM();
            Imposto I11 = new ImpostoAcimaDe10SM();

            I2.Proximo = I5;
            I5.Proximo = I10;
            I10.Proximo = I11;

            Console.WriteLine(I2.Calcula(Salario));
        }
    }
}
