using System;
using System.Collections.Generic;
using System.IO;

namespace Todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName; 

            try {
                string[] todoFile = File.ReadAllLines(filePath);
                
                foreach (string line in todoFile)
                {
                    string[] itens = line.Split(",");                             /*Split= quebra as string com "," e colocar em otro lugar "string/vetor"*/
                    string titulo = itens[0].Replace("\"", "");                                  /*Replace= subtituir por outra palavra */
                    string nota = itens[1].Replace("\"", "");

                    TodoItem todoItem = new TodoItem(titulo, nota);
                    todoList.Add(todoItem);
                                                                
                }

            } catch (IOException ioe) {
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao = 0;

            do{
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite uma opção");
                System.Console.WriteLine(" 1 - Adicionar Item");
                System.Console.WriteLine(" 2 - Remover Item");
                System.Console.WriteLine(" 3 - Sair do programa");
                System.Console.WriteLine("Opção");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        AddItem (todoList); 
                    break;
                    case 2:
                        RemoveItem(todoList);
                    break;
                    case 3:
                    System.Console.WriteLine("Tchau!");
                    break;
                    default:
                    System.Console.WriteLine("Opção invalida");
                    Console.ReadLine();
                    break;
                }

    
            } while(opcao != 3);
            
        }

        public static void ListaItens(List<TodoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Titulo {"",12} Notas");     /*{"",2} são os espaços que deixa disponovel */
            foreach (TodoItem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }

        public static void AddItem(List<TodoItem> todoList)         /*Adicionei AddItem */
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item: ");
            System.Console.WriteLine();
            System.Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);

            todoList.Add(item);
        }

        public static void RemoveItem(List<TodoItem> todoList)
        {
            int index = 0;
            do {
                Console.Clear();
                System.Console.WriteLine("Remove item");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID ou x para terminar");
                System.Console.WriteLine("ID: ");
                string id = Console.ReadLine();
                
                if (id.ToLower() == "x")
                {
                    break;
                }
                else {
                    index = int.Parse(id) - 1;          /*Fornecer a area que vai ser removido */
                }

                if ((index < 0) || (index > todoList.Count -1))
                {
                    System.Console.WriteLine("ID Invalido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                } else {
                    todoList.RemoveAt (index);
                }
            } while(true);
        }


    }
}
