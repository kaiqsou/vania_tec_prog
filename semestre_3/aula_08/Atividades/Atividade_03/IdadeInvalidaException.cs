namespace Atividade_03
{
    class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(){}
        public IdadeInvalidaException(string mensagem) : base(mensagem){}
        public IdadeInvalidaException(string mensagem, Exception innerException){}
    }
}
