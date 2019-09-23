using System;

namespace data_nasc
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano  = 0;
            int idade = 0;

            do{                                      //validar a entrada//

            Console.Write("Ano de nascimeto: ");   
            ano = int.Parse(Console.ReadLine());
            if((ano > 2021) || (ano <0)){
                Console.WriteLine("Data invalida");
                }
            }while((ano > 2021) || (ano <0));                     //validar a entrada//

            idade = 2019 - ano;

            if(idade < 3){
                Console.WriteLine("Recem Nascido");
            } else if((idade >= 3) && (idade <= 11)){
                Console.WriteLine("Crianção");
            } else if((idade >= 12) && (idade <= 19)){
                Console.WriteLine("Adolecente");
            } else if((idade >= 20) && (idade <= 65)){
                Console.WriteLine("Adulto");
            } else if((idade >= 65)) {
                Console.WriteLine("Idoso");
            }

        }
    }
}