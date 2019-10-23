using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, Ipercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Contrabaixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Contrabaixo.");
            return true;
        }

    }


}