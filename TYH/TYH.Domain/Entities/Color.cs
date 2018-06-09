using System.ComponentModel.DataAnnotations;

namespace TYH.Domain.Entities
{
    public class Color:DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Code { get; set; }
    }
}
