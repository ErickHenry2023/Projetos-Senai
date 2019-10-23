using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class Latinha : ILixeiraAMARELO
    {
        public bool RecipienteMetal()
        {
            System.Console.WriteLine("A sua Latinha foi jogado no lixo");
            return true;
        }
    }
}

