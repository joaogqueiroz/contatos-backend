namespace Contatos.Application.ViewModels
{
  public class ContatoViewModel
  {
    public ContatoViewModel(int id, string? tipo, string? valor, int pessoaId)
    {
      Id = id;
      Tipo = tipo;
      Valor = valor;
      PessoaId = pessoaId;
    }
    public int Id { get; private set; }
    public string? Tipo { get; private set; }
    public string? Valor { get; private set; }
    public int PessoaId { get; private set; }
  }
}