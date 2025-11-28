namespace _0._Architecture.Domain
{
    public interface IBusinessRule<T> where T : IEntity
    {
        static abstract void Check(T entity);
    }
}
