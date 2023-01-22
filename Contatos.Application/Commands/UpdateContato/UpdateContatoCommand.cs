using MediatR;

namespace Contatos.Application.Commands.UpdateContato
{
  public class UpdateContatoCommand : IRequest<Unit>
  {
    public int Id { get; private set; }
    public string? Tipo { get; private set; }
    public string? Valor { get; private set; }

  }
}