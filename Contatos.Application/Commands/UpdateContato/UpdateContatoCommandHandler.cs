using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Commands.UpdateContato
{
  public class UpdateContatoCommandHandler : IRequestHandler<UpdateContatoCommand, Unit>
  {
    private readonly IContatoRepository _contatoRepository;
    public UpdateContatoCommandHandler(IContatoRepository contatoRepository)
    {
      _contatoRepository = contatoRepository;
    }
    public async Task<Unit> Handle(UpdateContatoCommand request, CancellationToken cancellationToken)
    {
      var contato = await _contatoRepository.GetByIdAsync(request.Id);
      contato.Update(request.Tipo, request.Valor);
      await _contatoRepository.UpdateAsync(contato);
      return Unit.Value;
    }
  }
}