using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSemPadrao {
    public class Pessoa {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
        public string RG { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public char Sexo { get; private set; }
        public string NomePai { get; private set; }
        public string NomeMae { get; private set; }

        public Pessoa(string nome, string telefone, string cpf, string rg, string endereco, string nomePai, string nomeMae,
            char sexo, DateTime dataNascimento) {
                Nome = nome;
                Telefone = telefone;
                Cpf = cpf;
                RG = rg;
                Endereco = endereco;
                NomePai = nomePai;
                NomeMae = nomeMae;
                Sexo = sexo;
                DataNascimento = dataNascimento;
        }
        public override string ToString() {
            return Nome+" "+Endereco;
        }
    }
}
