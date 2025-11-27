using _0._Architecture.Domain;

namespace Domain.Entity
{
    public class Entity : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Data { get; set; }

        public void Mutate_Data(int newAmount)
        {
            if (newAmount < 0)
            {
                throw new Exception();
            }

            Data = newAmount;

            CheckInvariants();
        }

        public void CheckInvariants()
        {
            if (Data < 0)
            {
                throw new Exception();
            }
        }
    }
}
