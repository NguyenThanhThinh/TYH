using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class ProductImage : DomainEntity<int>
    {
        public int ProductId { get; set; }

        [ForeignKey(nameof(Product))]
        public virtual Product Product { get; set; }

        [StringLength(250)]
        public string Path { get; set; }

        [StringLength(250)]
        public string Caption { get; set; }
    }
}
