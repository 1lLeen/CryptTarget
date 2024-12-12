namespace CryptTarget.Models.Services.Interfaces
{
    public interface ICryptService
    {
        Task<List<Crypt>> GetCrypts(int? id);
        Task UpdateCrypts();
    }
}
