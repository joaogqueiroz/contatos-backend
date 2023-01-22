using MediatR;

namespace Contatos.Application.Commands.CreatePessoa
{
    public class CreatePessoaCommand : IRequest<int>
    {
        public string Nome { get; private set; }
    }
}