using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, Ipercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o ritmo do Baixo");
            return true;
        }
        
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }



    }
}