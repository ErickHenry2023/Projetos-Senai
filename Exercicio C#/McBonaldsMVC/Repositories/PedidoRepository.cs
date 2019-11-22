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
                pedido.Cliente = new Cliente();
                
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

        
            private string PrepararPedidoCSV(Pedido pedido)

        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"nome={c.Nome};endereco={c.Endereco};telefone={c.Telefone};email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DateDoPedido};preco_total={pedido.PrecoTotal};";
            
        }
    }
}