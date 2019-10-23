using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class GuardaChuva : ILixeiraCINZA
    {
        public bool RecipienteIndefinido()
        {
            System.Console.WriteLine("O seu Guarda-Chuva foi jogado no lixo");
            return true;
        }
    }
}