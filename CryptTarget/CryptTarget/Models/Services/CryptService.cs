using CryptTarget.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace CryptTarget.Models.Services
{
    public class CryptService
    {
        protected CryptContext _dbContext { get; set; }
        public CryptService(CryptContext cryptContext) 
        {
            _dbContext = cryptContext;
        }
        public async Task<List<Crypt>> GetCrypts(int? id)
        {
            switch (id)
            {
                case 1:
                    return await _dbContext.Crypts.OrderBy(c => c.Name).ToListAsync();
                case 2:
                    return await _dbContext.Crypts.OrderBy(c=>c.Symbol).ToListAsync();
                case 3:
                    return await _dbContext.Crypts.OrderBy(c=>c.Price).ToListAsync();
                case 4:
                    return await _dbContext.Crypts.OrderBy(c=>c.MarkteCap).ToListAsync();
                case 5:
                    return await _dbContext.Crypts.OrderBy(c=>c.LastUpdate).ToListAsync();
                case 6:
                    return await _dbContext.Crypts.OrderBy(c=>c.ValumeChange24H).ToListAsync();
                default:
                    return await _dbContext.Crypts.ToListAsync();

            }
        }
    }
}
