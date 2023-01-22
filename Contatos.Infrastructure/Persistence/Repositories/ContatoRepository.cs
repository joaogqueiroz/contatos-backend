using Contatos.Core.Entities;
using Contatos.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Infrastructure.Persistence.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly ContatosDbContext _dbContext;
        public ContatoRepository(ContatosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Contato>> GetAllAsync()
        {
            return await _dbContext.Contatos.ToListAsync();
        }

        public async Task AddAsync(Contato Contato)
        {
            await _dbContext.Contatos.AddAsync(Contato);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Contato Contato)
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Contato Contato)
        {
            _dbContext.Contatos.Remove(Contato);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Contato> GetByIdAsync(int id)
        {
            return await _dbContext.Contatos.SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}