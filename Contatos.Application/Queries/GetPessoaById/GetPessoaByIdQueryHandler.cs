using Contatos.Application.ViewModels;
using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Queries.GetPessoaById
{
  public class GetPessoaByIdQueryHandler : IRequestHandler<GetPessoaByIdQuery, PessoaViewModel>
  {
    private readonly IPessoaRepository _pessoaRepository;

    public GetPessoaByIdQueryHandler(IPessoaRepository pessoaRepository)
    {
      _pessoaRepository = pessoaRepository;
    }

    public async Task<PessoaViewModel> Handle(GetPessoaByIdQuery request, CancellationToken cancellationToken)
    {
      var pessoa = await _pessoaRepository.GetByIdAsync(request.Id);
      if (pessoa == null) return null;
      var pessoaViewModel = new PessoaViewModel
          (
          pessoa.Id,
          pessoa.Nome
          );
      return pessoaViewModel;
    }
  }
}