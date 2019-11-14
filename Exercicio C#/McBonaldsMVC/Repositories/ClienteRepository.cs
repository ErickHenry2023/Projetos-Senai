using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";     /*"PATH" Constantia  */         /*Apenas leitura sem modificar "const" */

        public ClienteRepository()
        {
            if(!File.Exists(PATH))                              /*Metodo "File" */
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente)};    
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome}; email={cliente.Email};senha ={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone}; data_nascimento={cliente.DataNascimento}";
        }
    }
}