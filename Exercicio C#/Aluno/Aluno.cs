using System;

namespace Aluno
{
    public class Aluno{         //colocar public nos atributos p/ poder utilizar//
        //Propriedades
    public string Nome{get;set;}
    public string Curso{get;set;}
    public string Cpf{get;set;}
    public int[] Notas;

        //Construtor//
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;       //"this" é p/ se referir a classe//
            this.Cpf = Cpf;
        }

        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        }

        //Metodos de Acesso
        public int[] getNotas(){return Notas;}

        public void setNotas(int bi, int nota){
            int i= bi - 1;
        }

    }
}