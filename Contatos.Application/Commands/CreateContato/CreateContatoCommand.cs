using MediatR;

namespace Contatos.Application.Commands.CreateContato
{
  public class CreateContatoCommand : IRequest<int>
  {
    public string? Tipo { get; set; }
    public string? Valor { get; set; }
    public int PessoaId { get; set; }
  }
}