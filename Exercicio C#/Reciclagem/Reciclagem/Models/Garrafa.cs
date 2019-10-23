using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{

    public class Garrafa : ILixeiraVERDE
    {

        public bool RecipienteVidro()
        {
            System.Console.WriteLine("A sua Garrafa foi jogado no lixo");
            return true;
        }
    }
}