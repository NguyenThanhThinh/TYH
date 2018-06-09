namespace TYH.Domain.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}
