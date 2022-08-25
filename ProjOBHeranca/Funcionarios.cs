using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOBHeranca {
    internal class Funcionarios:Pessoa {

        private long Pis;
        private float Salario;
        private String Setor;

        public Funcionarios(string nome, String dtNasc, int cpf, long pis, float salario, string setor) :
               base(nome, dtNasc, cpf) {

            this.Pis = pis;
            this.Salario = salario;
            this.Setor = setor;
        }

        public Funcionarios() { }

        public void setPis(long pis) {
            this.Pis = pis;
        }

        public long getPis() {
            return Pis;
        }

        public void setSalario(float salario) {
            this.Salario = Salario;
        }

        public float getSalario() {
            return Salario;
        }

        public void setSetor(String setor) {
            this.Setor=setor;
        }

        public String getSetor() {
            return Setor;
        }
       
        public override string ToString() {

            return base.ToString() + "\nPis: " + Pis +
                   "\nSalario: " + Salario +
                   "\nSetor: " + Setor;
        }

    }
}
