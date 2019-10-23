using System;

namespace SENAIzinho
{
    public class Sala
    {
    
    public int capacidadeAtual {get;set;}
    public int capacidadeTotal {get;set;}
    public int numeroSala {get;set;} 
    public string[] Alunos {get;set;}
    
    /*Inicio do costrutor */
    public Sala(int numeroSala, int capacidadeTotal)
    {
        this.numeroSala = numeroSala;
        this.capacidadeTotal = capacidadeTotal;
        this.capacidadeAtual = this.capacidadeTotal;
        this.Alunos = new string[capacidadeTotal];
    }
    /*Fim do costrutor */
        public string AlocarAluno (string NomeAluno)
        {
            int index = 0;
            if(this.capacidadeAtual > 0)
            {
                foreach(string aluno in this.Alunos)
                {
                    if (aluno == "")
                    {
                    this.Alunos[index] = NomeAluno;
                    break;
                    } 
                    index++;
                }
                this.capacidadeAtual --;
                return "Ok";
            } else
            {
                return "LOTADO";
            }
        }

            public string RemoverAluno (string NomeAluno)
            {
                int index = 0;

                if(this.capacidadeAtual == this.capacidadeTotal)
                {
                    return "SALAVAZIA";
                }

                foreach(string aluno in this.Alunos)
                {
                    if(NomeAluno == aluno)
                    {
                        this.Alunos[index] = "";
                        return "OK";
                    }
                    index++;
                }
                return "NAOENCONTRADO";
            }
            public String MostrarAlunos()
            {
                string listaAlunos="";
                foreach(string aluno in this.Alunos)
                {
                    if(aluno != "")
                    {
                        listaAlunos = listaAlunos + aluno + " ";
                    }
                }
                listaAlunos.TrimEnd();
                return listaAlunos;
            }



    }

}