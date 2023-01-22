using MediatR;

namespace Contatos.Application.Commands.DeleteContato
{
  public class DeleteContatoCommand : IRequest<Unit>
  {
    public DeleteContatoCommand(int id)
    {
      Id = id;
    }
    public int Id { get; set; }
  }
}