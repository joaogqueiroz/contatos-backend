using Contatos.Application.ViewModels;
using MediatR;

namespace Contatos.Application.Queries.GetAllPessoas
{
  public class GetAllPessoasQuery : IRequest<List<PessoaViewModel>>
  {
  }
}