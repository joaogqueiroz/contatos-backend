using Contatos.Application.ViewModels;
using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Queries.GetAllContatos
{
  public class GetAllContatosQueryHandler : IRequestHandler<GetAllContatosQuery, List<ContatoViewModel>>
  {
    private readonly IContatoRepository _contatoRepository;

    public GetAllContatosQueryHandler(IContatoRepository contatoRepository)
    {
      _contatoRepository = contatoRepository;
    }
    public async Task<List<ContatoViewModel>> Handle(GetAllContatosQuery request, CancellationToken cancellationToken)
    {
      var contatos = await _contatoRepository.GetAllAsync();
      var contatoViewModel = contatos
          .Select(m => new ContatoViewModel
          (
              m.Id,
              m.Tipo,
              m.Valor,
              m.PessoaId))
          .ToList();
      return contatoViewModel;

    }
  }
}