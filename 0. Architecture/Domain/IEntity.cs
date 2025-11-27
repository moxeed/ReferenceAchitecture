namespace _0._Architecture.Domain
{
    public interface IEntity
    {
        int Id { get; set; }
        void CheckInvariants();
    }
}
