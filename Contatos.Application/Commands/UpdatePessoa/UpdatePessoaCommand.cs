using MediatR;

namespace Contatos.Application.Commands.UpdatePessoa
{
  public class UpdatePessoaCommand : IRequest<Unit>
  {
    public int Id { get; private set; }
    public string? Nome { get; private set; }

  }
}