using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class PoteManteiga : ILixeiraVERMELHO
    {
        public bool RecipientePlastico()
        {
            System.Console.WriteLine("O seu Pote-Manteiga foi jogado no lixo");
            return true;
        }
    }
}