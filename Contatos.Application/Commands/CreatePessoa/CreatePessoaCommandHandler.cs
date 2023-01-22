using Contatos.Application.Commands.CreatePessoa;
using Contatos.Core.Entities;
using Contatos.Core.Repositories;
using MediatR;

namespace Pessoas.Application.Commands.CreatePessoa
{
    public class CreatePessoaCommandHandler : IRequestHandler<CreatePessoaCommand, int>
    {
        private readonly IPessoaRepository _pessoaRepository;
        public CreatePessoaCommandHandler(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public async Task<int> Handle(CreatePessoaCommand request, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa(request.Nome);
            await _pessoaRepository.AddAsync(pessoa);
            return pessoa.Id;
        }
    }
}