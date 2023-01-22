using MediatR;

namespace Contatos.Application.Commands.DeletePessoa
{
  public class DeletePessoaCommand : IRequest<Unit>
  {
    public DeletePessoaCommand(int id)
    {
      Id = id;
    }
    public int Id { get; set; }
  }
}