using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            PessoaBuilder PB = new PessoaBuilder();
            Pessoa P = PB
                .ComNome("Natanael")
                .ComNomeMae("Maria")
                .ComNomePai("Joao")
                .ComEndereco("Rua Academia 1371")
                .ComCpf("111111111-11")
                .ComRG("11111111-1")
                .ComSexo('m')
                .ComTelefone("9999-9999")
                .ComDataNascimento(new DateTime(1993,12,20))
                .Constroi();
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
