using System.ComponentModel.DataAnnotations;

namespace TYH.Domain.Entities
{
    public class Size:DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
    }
}
