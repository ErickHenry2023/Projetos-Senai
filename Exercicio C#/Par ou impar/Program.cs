using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num= 1;*/
            int num = 0;
            do{                                             /*Digitar 0 ele para */
            /*whilw(num !=0){ */

                Console.Write("Digite Um Numero: ");      
            num = int.Parse(Console.ReadLine());            /*Passos necessarios p/ começar */

            if(num % 2 == 0){                               /*if((num % 2) != 0){       ****P/deixar impar primeiro****/ 
                Console.WriteLine("Numero par");            /*Console.WriteLine("Numero impar"); */
            } else{
                Console.WriteLine("Numero impar");
            }


            }while(num !=0);                                /*Digitar 0 ele para */

        }
    }
}
