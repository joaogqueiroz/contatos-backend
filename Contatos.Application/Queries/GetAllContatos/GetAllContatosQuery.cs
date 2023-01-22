using Contatos.Application.ViewModels;
using MediatR;

namespace Contatos.Application.Queries.GetAllContatos
{
  public class GetAllContatosQuery : IRequest<List<ContatoViewModel>>
  {
  }
}