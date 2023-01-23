using MediatR;

namespace Contatos.Application.Commands.UpdateContato
{
  public class UpdateContatoCommand : IRequest<Unit>
  {
    public int Id { get; set; }
    public string? Tipo { get; set; }
    public string? Valor { get; set; }

  }
}