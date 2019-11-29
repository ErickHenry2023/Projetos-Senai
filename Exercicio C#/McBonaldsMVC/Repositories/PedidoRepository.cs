using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";     /*"PATH" Constantia  */         /*Apenas leitura sem modificar "const" */

        public PedidoRepository()
        {
            if(!File.Exists(PATH))                              /*Metodo "File" */
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedidio)
        {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;         /*Devolve o tamanho do vector "Length" */
            pedidio.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] {PrepararPedidoCSV(pedidio)};    
            File.AppendAllLines(PATH, linha);                   /*"AppendAllLines"= Acrescenta (CVS)linhas a um arquivo e fecha o arquivo */

            return true;
        }

        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos(); 
            List<Pedido> pedidosCliente = new List<Pedido>();

            foreach (var pedido in pedidos)
            {
                if (pedido.Cliente.Email.Equals(emailCliente)) 
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        public List<Pedido> ObterTodos()                                /*Foi criado 21/11 hacer login */
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos =new List<Pedido> ();

            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();
                // pedido.Cliente = new Cliente();
                
                pedido.Id= ulong.Parse(ExtrairValorDoCampo("id", linha));
                pedido.Status =uint.Parse(ExtrairValorDoCampo("status_pedido", linha)); /*28/11 */

                pedido.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("email", linha);

                pedido.Hamburguer.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco", linha));

                pedido.Shake.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));

                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                pedido.DateDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));

                pedidos.Add(pedido);

            }
            
            return pedidos;
        }

            public Pedido ObterPor(ulong id)
            {
                var pedidosTotais =ObterTodos();
                foreach (var pedido in pedidosTotais)
                {
                    if (id.Equals(pedido.Id))
                    {
                        return pedido;
                    }
                }
                return null;
            }

            public bool Atualizar(Pedido pedido)
            {
                var pedidosTotais = File.ReadAllLines(PATH);
                var pedidoCSV = PrepararPedidoCSV(pedido);
                var linhaPedido = -1;
                var resultado = false;

                for (int i = 0; i < pedidosTotais.Length; i++)
                {
                    var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", pedidosTotais[i]));
                    if (pedido.Id.Equals(idConvertido))
                    {
                        linhaPedido = i;
                        resultado = true;
                        break;
                    }
                }

                if(resultado)
                {
                    pedidosTotais[linhaPedido] = pedidoCSV;
                    File.WriteAllLines(PATH, pedidosTotais);
                }
                    return resultado;
            }

            private string PrepararPedidoCSV(Pedido pedido)         /*gravar no banco "PrepararPedidoCSV" */
        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"id={pedido.Id};status_pedido={pedido.Status};nome={c.Nome};endereco={c.Endereco};telefone={c.Telefone};email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DateDoPedido};preco_total={pedido.PrecoTotal};";
            
        }
    }
}