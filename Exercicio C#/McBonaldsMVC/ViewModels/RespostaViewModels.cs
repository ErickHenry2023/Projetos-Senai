namespace McBonaldsMVC.ViewModels               /*crio o arquivo */
{
    public class RespostaViewModels
    {
        public string Mensagem {get; set;}

        public RespostaViewModels()
        {

        }

        public RespostaViewModels(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}