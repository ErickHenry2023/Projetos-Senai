namespace McBonaldsMVC.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer(string nome, double preco)
        {
            this.Nome =nome;
            this.Preco = preco;
        }

        public Hamburguer ()
        {
            
        }
    }
}