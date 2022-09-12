using System;

namespace ProjOBHeranca {
    internal class Program {
        static void Main(string[] args) {
         

                                  //ALUNO:PESSOA(HERANÇA)
         // __________________________________________________________________________________________________________________________________//
            Aluno aluno1=new Aluno();

            aluno1.setNome("Manuela");
            aluno1.setDataNasc("17/11/1993");
            aluno1.setCpf(89756002);
            aluno1.setRa(202223987);
            aluno1.setDatamatricula("12/02/2022");
           
            Console.WriteLine("\n**** Cadastro Aluno ****")
            Console.WriteLine(aluno1.ToString());

            Aluno aluno2 = new Aluno("Larissa","07/09/1990",87654895,1236854,"03/08/2022");
            
            Console.WriteLine("\n**** Cadastro Aluno ****");
            Console.WriteLine(aluno2.ToString());
            //__________________________________________________________________________________________________________________________________//

           
            
                                                // Funcionarios:Pessoa(Herança)
            //__________________________________________________________________________________________________________________________________//
            Funcionarios funcionario1 = new Funcionarios("Carlos","20/10/1995",875642358,5489868,2500,"Operador de Empilhadeira");
            Console.WriteLine("\n**** Cadastro Funcionarios ****");
            Console.WriteLine(funcionario1.ToString());

            Funcionarios funcionario2 = new Funcionarios();

            funcionario2.setNome("Leandro");
            funcionario2.setDataNasc("17/11/1993");
            funcionario2.setCpf(89756002);
            funcionario2.setPis(3232464654);
            funcionario2.setSalario(1800);
            funcionario2.setSetor("Estoquista");

            Console.WriteLine("\n**** Cadastro Funcionarios ****");
            Console.WriteLine(funcionario2.ToString());














        }
    }
}
