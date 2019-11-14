using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository
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

            private string PrepararPedidoCSV(Pedido pedido)

        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"cliente_nome= {c.Nome}; cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome={h.Nome};hamburguer_preco={h.Preco};shake_nome={s.Nome};shake_preco={s.Preco};data_pedido={pedido.DateDoPedido};preco_total={pedido.PrecoTotal};";
            
        }




    }
}