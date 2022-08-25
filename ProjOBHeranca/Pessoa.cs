using System;


namespace ProjOBHeranca {
    internal class Pessoa {

        private String Nome;
        private String DataNasc;
        private int Cpf;

        public Pessoa(String nome, String dataNasc, int cpf) {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Cpf = cpf;
        }

        public Pessoa() { }

        public void setNome(String nome) {
            this.Nome = nome ;
        }

        public String getNome(String nome) {
            return nome;
        }

        public void setDataNasc(String dataNasc) {
            this.DataNasc = dataNasc;
        }

        public String getDataNasc(String dataNasc) {
            return dataNasc;
        }

        public void setCpf(int cpf) {
            this.Cpf = cpf;
        }

        public int getCpf(int cpf) {
            return cpf;
        }

        public override String ToString() {
            return"\nNome: " + Nome +
                   "\nData de Nascimento: " + DataNasc +
                   "\nCPF: " + Cpf;
                  
        }






    }
}
