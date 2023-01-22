using Contatos.Application.ViewModels;
using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Queries.GetContatoById
{
  public class GetContatoByIdQueryHandler : IRequestHandler<GetContatoByIdQuery, ContatoViewModel>
  {
    private readonly IContatoRepository _contatoRepository;

    public GetContatoByIdQueryHandler(IContatoRepository contatoRepository)
    {
      _contatoRepository = contatoRepository;
    }

    public async Task<ContatoViewModel> Handle(GetContatoByIdQuery request, CancellationToken cancellationToken)
    {
      var contato = await _contatoRepository.GetByIdAsync(request.Id);
      if (contato == null) return null;
      var contatoViewModel = new ContatoViewModel
          (
          contato.Id,
          contato.Tipo,
          contato.Valor,
          contato.PessoaId
          );
      return contatoViewModel;
    }
  }
}