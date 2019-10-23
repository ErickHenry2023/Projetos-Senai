using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, Ipercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo da Bateria.");
            return true;
        }
    }
}