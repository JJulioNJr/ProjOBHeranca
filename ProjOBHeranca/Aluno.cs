using System;


namespace ProjOBHeranca {
    internal class Aluno : Pessoa {

        private int Ra;
        private String DataMatricula;


        public Aluno(string nome, String data, int cpf, int ra, String dtMatricula) :
               base(nome, data, cpf) {

            this.Ra = ra;
            this.DataMatricula = dtMatricula;
        }

        public Aluno() { }
       
        public void setRa(int ra) {
            this.Ra = ra;
        }
        public int getRa() {
            return Ra;
        }

        public void setDatamatricula(String dtMatricula) {
            this.DataMatricula = dtMatricula;
        }

        public String getDatamatricula() {
            return DataMatricula;   
        }
       
        public override string ToString() {

            return base.ToString()+ "\nRa: " + Ra +
                   "\nData da Matricula: " + DataMatricula;

        }
    }
}
