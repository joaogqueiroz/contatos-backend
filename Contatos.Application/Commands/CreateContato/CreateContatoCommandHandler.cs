using Contatos.Core.Entities;
using Contatos.Core.Repositories;
using MediatR;

namespace Contatos.Application.Commands.CreateContato
{
    public class CreateContatoCommandHandler : IRequestHandler<CreateContatoCommand, int>
    {
        private readonly IContatoRepository _contatoRepository;
        public CreateContatoCommandHandler(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public async Task<int> Handle(CreateContatoCommand request, CancellationToken cancellationToken)
        {
            var contato = new Contato(request.Tipo, request.Valor, request.PessoaId);
            await _contatoRepository.AddAsync(contato);
            return contato.Id;
        }
    }
}