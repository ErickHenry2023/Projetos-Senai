using system;

namespace EscolaDeRock.Models
{
    class IntrumentoMusical
    {
        string[] notas = {"Do", "Re", "Mi", "Fã", "Sol", "Lá", "Si"};
        public string TocarMusica()
        {
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}