using Domain.Entity;

namespace Domain._3._Services
{
    public class TrasnferDataService
    {
        public TrasnferDataService(Wallet fromEntity, Wallet toEntity, int amount)
        {
            fromEntity.ChangeData(-amount);
            toEntity.ChangeData(amount);

            
        }
    }
}
