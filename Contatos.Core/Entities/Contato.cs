namespace Contatos.Core.Entities
{
    public class Contato : BaseEntity
    {
        public Contato(string? tipo, string? valor, int pessoaId)
        {
            Tipo = tipo;
            Valor = valor;
            PessoaId = pessoaId;
        }

        public string? Tipo { get; private set; }
        public string? Valor { get; private set; }
        public int PessoaId { get; private set; }
        public Pessoa Pessoa { get; private set; }
    }
}