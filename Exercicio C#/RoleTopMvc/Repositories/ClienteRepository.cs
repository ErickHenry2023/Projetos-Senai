using System;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class ClienteRepository : RepositoryBase
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

        public Cliente ObterPor (string email)                          /*P/ hacer login del usuario */
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    
                    return c;
                }
            }
            return null; 
        }



        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone}";
        }
    }
}