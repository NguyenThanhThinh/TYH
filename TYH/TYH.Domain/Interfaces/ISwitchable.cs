namespace TYH.Domain.Interfaces
{
    using TYH.Domain.Enums;
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
