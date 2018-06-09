namespace TYH.Domain.Entities
{
    using TYH.Domain.Interfaces;
    using TYH.Domain.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Page : DomainEntity<int>, ISwitchable
    {
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}
