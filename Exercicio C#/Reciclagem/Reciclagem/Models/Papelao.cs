using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class Papelao : ILixeiraAZUL
    {
        public bool RecipientePapel()
        {
            System.Console.WriteLine("O seu papelão foi jogado no lixo");
            return true;
        }
    }
}