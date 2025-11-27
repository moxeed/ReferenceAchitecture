using _0._Architecture.Domain;

namespace _0._Architecture.Infrastructure
{
    public interface IRepository<T> where T : IDependecy<T>
    {
    }
}
