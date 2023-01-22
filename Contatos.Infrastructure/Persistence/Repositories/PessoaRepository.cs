using Contatos.Core.Entities;
using Contatos.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Infrastructure.Persistence.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ContatosDbContext _dbContext;
        public PessoaRepository(ContatosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Pessoa>> GetAllAsync()
        {
            return await _dbContext.Pessoas.ToListAsync();
        }

        public async Task AddAsync(Pessoa Pessoa)
        {
            await _dbContext.Pessoas.AddAsync(Pessoa);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pessoa Pessoa)
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Pessoa Pessoa)
        {
            _dbContext.Pessoas.Remove(Pessoa);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Pessoa> GetByIdAsync(int id)
        {
            return await _dbContext.Pessoas.SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}