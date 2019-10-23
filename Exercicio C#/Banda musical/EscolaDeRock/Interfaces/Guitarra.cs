using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, Imelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar acordes da Guitarra.");
            return true;
        }
        
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar solo da Guitarra.");
            return true;
        }
    }

}