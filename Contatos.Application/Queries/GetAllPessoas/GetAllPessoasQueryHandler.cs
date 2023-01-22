using Contatos.Application.ViewModels;
using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Queries.GetAllPessoas
{
  public class GetAllPessoasQueryHandler : IRequestHandler<GetAllPessoasQuery, List<PessoaViewModel>>
  {
    private readonly IPessoaRepository _pessoaRepository;

    public GetAllPessoasQueryHandler(IPessoaRepository pessoaRepository)
    {
      _pessoaRepository = pessoaRepository;
    }
    public async Task<List<PessoaViewModel>> Handle(GetAllPessoasQuery request, CancellationToken cancellationToken)
    {
      var pessoas = await _pessoaRepository.GetAllAsync();
      var pessoaViewModel = pessoas
          .Select(m => new PessoaViewModel
          (
              m.Id,
              m.Nome))
          .ToList();
      return pessoaViewModel;

    }
  }
}