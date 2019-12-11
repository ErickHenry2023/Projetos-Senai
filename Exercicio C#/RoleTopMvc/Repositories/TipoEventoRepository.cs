using System.Collections.Generic;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class TipoEventoRepository
    {
        private const string PATH = "Database/TipoDeEvento.csv";

        public double ObterPrecoDe(string nomeTipoEvento)               /*/*Para pegar o preço do produto */ 
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeTipoEvento))
                {
                    preco = item.Preco;
                    break;
                }
                
            }
            return preco;
        }

        public List<TipoDeEvento> ObterTodos()
        {
            List<TipoDeEvento> tipoDeEvento = new List<TipoDeEvento>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                TipoDeEvento s = new TipoDeEvento();
                string[] dados =linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                tipoDeEvento.Add(s);
            }

            return tipoDeEvento;
        }
    }
}