using Contatos.Application.Commands.UpdatePessoa;
using Contatos.Core.Repositories;
using MediatR;

namespace Pessoas.Application.Commands.UpdatePessoa
{
  public class UpdatePessoaCommandHandler : IRequestHandler<UpdatePessoaCommand, Unit>
  {
    private readonly IPessoaRepository _pessoaRepository;
    public UpdatePessoaCommandHandler(IPessoaRepository pessoaRepository)
    {
      _pessoaRepository = pessoaRepository;
    }
    public async Task<Unit> Handle(UpdatePessoaCommand request, CancellationToken cancellationToken)
    {
      var pessoa = await _pessoaRepository.GetByIdAsync(request.Id);
      pessoa.Update(request.Nome);
      await _pessoaRepository.UpdateAsync(pessoa);
      return Unit.Value;
    }
  }
}