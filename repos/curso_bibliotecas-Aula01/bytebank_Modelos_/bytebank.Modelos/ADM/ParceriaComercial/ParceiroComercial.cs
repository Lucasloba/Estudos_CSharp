using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos_.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        //public                //Autenticador
        private AutenticacaoUtil autenticavel { get; set; }
      
        public bool Autenticar(string senha)
        {
            return this.autenticavel.ValidarSenha(this.Senha, senha);
        }
    }
}
