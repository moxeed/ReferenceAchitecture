using _0._Architecture.Domain;

namespace Domain._2._ValueObject
{
    public class PositiveData : IValueObject
    {
        public int Data { get; }

        public PositiveData(int data)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(data);

            Data = data;
        }
    }
}
