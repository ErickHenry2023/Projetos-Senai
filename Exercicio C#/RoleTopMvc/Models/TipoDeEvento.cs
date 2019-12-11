namespace RoleTopMvc.Models
{
    public class TipoDeEvento
    {
        public string Nome {get;set;}
       public double Preco {get; set;}

        public TipoDeEvento()
        {
            
        }

       public TipoDeEvento( string nome, double preco)
       {
            this.Nome = nome;
            this.Preco = preco;
       }
    }
}