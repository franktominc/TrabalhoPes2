using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public class PessoaBuilder {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
        public string RG { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public char Sexo { get; private set; }
        public string NomePai { get; private set; }
        public string NomeMae { get; private set; }

        public PessoaBuilder ComNome(string nome){
            Nome = nome;
            return this;
        }
        public PessoaBuilder ComTelefone(string telefone) {
            Telefone = telefone;
            return this;
        }
        public PessoaBuilder ComCpf(string cpf) {
            Cpf = cpf;
            return this;
        }
        public PessoaBuilder ComRG(string rg){
            RG = rg;
            return this;
        }
        public PessoaBuilder ComEndereco(string endereco){
            Endereco = endereco;
            return this;
        }
        public PessoaBuilder ComSexo(char sexo) {
            Sexo = sexo;
            return this;
        }
        public PessoaBuilder ComNomePai(string nomePai) {
            NomePai = nomePai;
            return this;
        }
        public PessoaBuilder ComNomeMae(string nomeMae) {
            NomeMae = nomeMae;
            return this;
        }
        public PessoaBuilder ComDataNascimento(DateTime nascimento) {
            DataNascimento = nascimento;
            return this;
        }
        public Pessoa Constroi() {
            return new Pessoa(Nome, Telefone, Cpf, RG, Endereco, NomePai, NomeMae, Sexo, DataNascimento);
        }
    }
}
