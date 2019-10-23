using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class GarrafaPET : ILixeiraVERMELHO
    {
        public bool RecipientePlastico()
        {
            System.Console.WriteLine("A sua Garrafa-PET foi jogado no lixo");
            return true;
        }
    }
}