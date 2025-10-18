namespace Atividade_04
{
    class PrecoInvalidoError : Exception
    {
        public PrecoInvalidoError() { }
        public PrecoInvalidoError(string mensagem) : base(mensagem) { }
        public PrecoInvalidoError(string mensagem, Exception innerException) { }
    }
}