using Contatos.Application.ViewModels;
using MediatR;

namespace Contatos.Application.Queries.GetPessoaById
{
  public class GetPessoaByIdQuery : IRequest<PessoaViewModel>
  {
    public GetPessoaByIdQuery(int id)
    {
      Id = id;
    }

    public int Id { get; set; }
  }
}