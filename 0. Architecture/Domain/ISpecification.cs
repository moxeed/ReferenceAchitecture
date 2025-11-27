namespace _0._Architecture.Domain
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T candidate);
    }
}
