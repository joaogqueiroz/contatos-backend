using Contatos.Core.Entities;

namespace Contatos.Core.Repositories
{
    public interface IPessoaRepository
    {
        Task<List<Pessoa>> GetAllAsync();
        Task<Pessoa> GetByIdAsync(int id);
        Task AddAsync(Pessoa Pessoa);
        Task UpdateAsync(Pessoa Pessoa);
        Task DeleteAsync(Pessoa Pessoa);
    }
}