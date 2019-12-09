using System.Collections.Generic;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class ServicoRepository
    {
        private const string PATH = "Database/Servico.csv";

        public double ObterPrecode(string nomeServico)               /*/*Para pegar o preço do produto */ 
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeServico))
                {
                    preco = item.Preco;
                    break;
                }
                
            }
            return preco;
        }

        public List<Servico> ObterTodos()
        {
            List<Servico> servicos = new List<Servico>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Servico h = new Servico();
                string[] dados =linha.Split(";");
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                servicos.Add(h);
            }

            return servicos;
        }
    }
}