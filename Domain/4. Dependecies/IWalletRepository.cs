using _0._Architecture.Domain;
using Domain.Entity;

namespace Domain._4._Dependecies
{
    public interface IWalletRepository : IDependecy<IWalletRepository>
    {
        Task<Wallet> GetWalletById(int id);
    }
}
