using System.Collections.Generic;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {

        private const string PATH = "Database/Agendamento.csv";
        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento)
        {
            var quantidadeeventos = File.ReadAllLines(PATH).Length;         /*Devolve o tamanho do vector "Length" */
            evento.Id = (ulong) ++quantidadeeventos;
            var linha = new string[] {PrepararEventoCSV(evento)};    
            File.AppendAllLines(PATH, linha); 

            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos(); 
            List<Evento> eventosCliente = new List<Evento>();

            foreach (var evento in eventos)
            {
                if (evento.Cliente.Email.Equals(emailCliente)) 
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }

        public List<Evento> ObterTodos()                                /*Foi criado 21/11 hacer login */
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos =new List<Evento> ();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                // evento.Cliente = new Cliente();
                
                evento.Id= ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status =uint.Parse(ExtrairValorDoCampo("status_evento", linha)); /*28/11 */

                evento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                // evento.Cliente.Endereco = ExtrairValorDoCampo("endereco", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("email", linha);

                // evento.Hamburguer.Nome = ExtrairValorDoCampo("shake_nome", linha);
                // evento.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco", linha));

                // evento.Shake.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                // evento.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));

                // evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                // evento.DateDoevento = DateTime.Parse(ExtrairValorDoCampo("data_evento", linha));

                eventos.Add(evento);

            }
            
            return eventos;
        }

            public Evento ObterPor(ulong id)
            {
                var eventosTotais =ObterTodos();
                foreach (var evento in eventosTotais)
                {
                    if (id.Equals(evento.Id))
                    {
                        return evento;
                    }
                }
                return null;
            }

            public bool Atualizar(Evento evento)
            {
                var eventosTotais = File.ReadAllLines(PATH);
                var eventoCSV = PrepararEventoCSV(evento);
                var linhaevento = -1;
                var resultado = false;

                for (int i = 0; i < eventosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                    if (evento.Id.Equals(idConvertido))
                    {
                        linhaevento = i;
                        resultado = true;
                        break;
                    }
                }

                if(resultado)
                {
                    eventosTotais[linhaevento] = eventoCSV;
                    File.WriteAllLines(PATH, eventosTotais);
                }
                    return resultado;
            }

            private string PrepararEventoCSV(Evento evento)         /*gravar no banco "PrepararEventoCSV" */
        {
            Cliente c = evento.Cliente;
            // Hamburguer h = evento.Hamburguer;
            // Shake s = evento.Shake;

            return $"id={evento.Id};status_evento={evento.Status};nome={c.Nome};telefone={c.Telefone};email={c.Email};";        
            // (revisar aqui)) hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_evento={evento.DateDoevento};preco_total={evento.PrecoTotal};//
            
        }
    }
}