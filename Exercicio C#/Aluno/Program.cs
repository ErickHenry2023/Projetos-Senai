using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Jefferson", "123.456.789-00");         //aluno1 objeto//
            Aluno aluno2 = new Aluno("Torres", "987.654.321-00", "Prog1");
            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Cpf: " + aluno1.Cpf);
            Console.WriteLine("Curso: " + aluno1.Curso);

            Console.WriteLine("Nome: " + aluno2.Nome);
            Console.WriteLine("Cpf: " + aluno2.Cpf);
            Console.WriteLine("Curso: " + aluno2.Curso);

            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o cpf: ");
            string Cpf = Console.ReadLine();
            Console.Write("Entre com o curso: ");
            string Curso = Console.ReadLine();
            Console.Write("Entre com o nota: ");
            string nome = Console.ReadLine();
            int nota =int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre =int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,Cpf,Curso);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("CPF: " + aluno3.Nome);
            Console.WriteLine("Curso: " + aluno3.Nome);
            Console.WriteLine("Notas: " + );
            foreach(int

        }
    }
}
