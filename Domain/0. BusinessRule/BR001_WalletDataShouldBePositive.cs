using _0._Architecture.Domain;
using Domain.Entity;

namespace Domain._0._BusinessRule
{
    internal class BR001_WalletDataShouldBePositive : IBusinessRule<Wallet>
    {
        public static void Check(Wallet entity)
        {
            if (entity.Data < 0)
                throw new ArgumentException($"Violation Of {nameof(BR001_WalletDataShouldBePositive)}");
        }
    }
}
