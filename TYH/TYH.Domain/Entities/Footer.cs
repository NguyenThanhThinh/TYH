using System.ComponentModel.DataAnnotations;

namespace TYH.Domain.Entities
{
    public class Footer : DomainEntity<string>
    {
        [Required]
        public string Content { set; get; }
    }
}
