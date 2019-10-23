using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, Ipercussao
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violão.");
            return true;
        }






        
    }
}