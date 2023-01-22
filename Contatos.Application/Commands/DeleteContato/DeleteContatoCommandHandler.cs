using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Commands.DeleteContato
{
  public class DeleteContatoCommandHandler : IRequestHandler<DeleteContatoCommand, Unit>
  {
    private readonly IContatoRepository _contatoRepository;
    public DeleteContatoCommandHandler(IContatoRepository contatoRepository)
    {
      _contatoRepository = contatoRepository;
    }
    public async Task<Unit> Handle(DeleteContatoCommand request, CancellationToken cancellationToken)
    {
      var contato = await _contatoRepository.GetByIdAsync(request.Id);
      await _contatoRepository.DeleteAsync(contato);
      return Unit.Value;
    }
  }
}