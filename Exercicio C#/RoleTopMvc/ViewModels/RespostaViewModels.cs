namespace RoleTopMvc.ViewModels
{
    public class RespostaViewModels : BaseViewModels
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