using Contatos.Core.Entities;

namespace Contatos.Core.Repositories
{
    public interface IContatoRepository
    {
        Task<List<Contato>> GetAllAsync();
        Task<Contato> GetByIdAsync(int id);
        Task AddAsync(Contato Contato);
        Task UpdateAsync(Contato Contato);
        Task DeleteAsync(Contato Contato);
    }
}