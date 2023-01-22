using MediatR;

namespace Contatos.Application.Commands.CreateContato
{
    public class CreateContatoCommand : IRequest<int>
    {
        public string? Tipo { get; private set; }
        public string? Valor { get; private set; }
        public int PessoaId { get; private set; }
    }
}