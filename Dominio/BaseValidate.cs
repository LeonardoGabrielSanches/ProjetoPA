namespace VendasAPI.Domínio.Entidades
{//tentativa merge
    public class BaseValidate
    {
        public BaseValidate()
        {
            Result = new ValidateResult();
        }
        public ValidateResult Result { get; set; }

    }
    public class ValidateResult
    {
        private string _mensagemErro;

        public string MensagemErro
        {
            get => _mensagemErro;
            set
            {
                _mensagemErro = value;
                Isvalid = string.IsNullOrEmpty(_mensagemErro) ? true : false;
            }
        }

        public bool Isvalid { get; set; } = true;
    }
}
