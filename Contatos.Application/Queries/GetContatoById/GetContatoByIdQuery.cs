using Contatos.Application.ViewModels;
using MediatR;

namespace Contatos.Application.Queries.GetContatoById
{
  public class GetContatoByIdQuery : IRequest<ContatoViewModel>
  {
    public GetContatoByIdQuery(int id)
    {
      Id = id;
    }

    public int Id { get; set; }
  }
}