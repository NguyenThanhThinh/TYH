namespace TYH.Domain.Entities
{
    using TYH.Domain.Interfaces;
    using TYH.Domain.Enums;
    using System.ComponentModel.DataAnnotations;
    public class Language : DomainEntity<string>, ISwitchable
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
