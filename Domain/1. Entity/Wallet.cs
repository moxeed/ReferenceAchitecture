using _0._Architecture.Domain;
using Domain._0._BusinessRule;
using Domain._2._ValueObject;

namespace Domain.Entity
{
    public class Wallet : IEntity
    {
        public int Id { get; set; }
        public int Data { get; set; }

        public void SetData(PositiveData newAmount)
        {
            Data = newAmount.Data;

            CheckInvariants();
        }

        public void ChangeData(int newAmount)
        {
            Data += newAmount;

            CheckInvariants();
        }

        public void CheckInvariants()
        {
            BR001_WalletDataShouldBePositive.Check(this);
        }
    }
}