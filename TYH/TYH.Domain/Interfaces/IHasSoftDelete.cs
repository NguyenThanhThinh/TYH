namespace TYH.Domain.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
