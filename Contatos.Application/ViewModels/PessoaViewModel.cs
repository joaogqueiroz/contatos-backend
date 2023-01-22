namespace Contatos.Application.ViewModels
{
  public class PessoaViewModel
  {
    public PessoaViewModel(int id, string nome)
    {
      Id = id;
      Nome = nome;
    }
    public int Id { get; private set; }
    public string Nome { get; private set; }
  }
}