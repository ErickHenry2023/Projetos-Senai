using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMvc.Models;

namespace RoleTopMvc.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
        public TipoEventoRepository tipoEventoRepository = new TipoEventoRepository();
        private const string PATH = "Database/Agendamento.csv"; /*quizas sea "servico" */
        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento agendamento)
        {
            var linha = new string[] {FazerRegistroCSV(agendamento)};
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
        public List<Evento> ObterTodos()                                
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos =new List<Evento> ();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                
                evento.Id= ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status =uint.Parse(ExtrairValorDoCampo("status_agendamento", linha)); 

                evento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("email", linha);

                
                string nomeTipoEvento = ExtrairValorDoCampo("tipo_evento", linha);

                evento.TipoEvento = new TipoDeEvento(nomeTipoEvento, tipoEventoRepository.ObterPrecoDe(nomeTipoEvento));
                evento.PrecoTipoEvento = double.Parse(ExtrairValorDoCampo("preco_t_evento", linha));
                evento.PrecoAdicionais = double.Parse(ExtrairValorDoCampo("preco_adicionais", linha));


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
                var eventoCSV = FazerRegistroCSV(evento);
                var linhaEvento = -1;
                var resultado = false;

                for (int i = 0; i < eventosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                    if (evento.Id.Equals(idConvertido))
                    {
                        linhaEvento = i;
                        resultado = true;
                        break;
                    }
                }

                if(resultado)
                {
                    eventosTotais[linhaEvento] = eventoCSV;
                    File.WriteAllLines(PATH, eventosTotais);
                }
                    return resultado;
            }

        private string FazerRegistroCSV(Evento agendamento)
        {
            Cliente c = agendamento.Cliente;
            Evento e = agendamento;

            return $"id={agendamento.Id};status_agendamento={agendamento.Status};nome={c.Nome};telefone={c.Telefone};email={c.Email};preco_t_evento={agendamento.PrecoTipoEvento};tipo_evento={agendamento.TipoEvento.Nome};preco_adicionais={agendamento.PrecoAdicionais}";
        }
    }
}