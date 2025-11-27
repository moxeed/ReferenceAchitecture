namespace _0._Architecture.Domain
{
    public interface IBusinessRule<T> where T : IEntity
    {
        void Check(T entity);
    }
}
