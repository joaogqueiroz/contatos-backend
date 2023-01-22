using Contatos.Application.Commands.DeletePessoa;
using Contatos.Core.Repositories;
using MediatR;

namespace Pessoas.Application.Commands.DeletePessoa
{
  public class DeletePessoaCommandHandler : IRequestHandler<DeletePessoaCommand, Unit>
  {
    private readonly IPessoaRepository _pessoaRepository;
    public DeletePessoaCommandHandler(IPessoaRepository pessoaRepository)
    {
      _pessoaRepository = pessoaRepository;
    }
    public async Task<Unit> Handle(DeletePessoaCommand request, CancellationToken cancellationToken)
    {
      var pessoa = await _pessoaRepository.GetByIdAsync(request.Id);
      await _pessoaRepository.DeleteAsync(pessoa);
      return Unit.Value;
    }
  }
}