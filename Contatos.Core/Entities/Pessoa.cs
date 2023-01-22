namespace Contatos.Core.Entities
{
    public class Pessoa : BaseEntity
    {
        public Pessoa(string nome)
        {
            Nome = nome;            
        }
        public string Nome { get; private set; }
        public List<Contato> Contatos { get; private set; }
    }
}