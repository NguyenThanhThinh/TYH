using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class ProductTag : DomainEntity<int>
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { set; get; }

        [ForeignKey(nameof(Product))]
        public virtual Product Product { set; get; }

        [ForeignKey(nameof(Tag))]
        public virtual Tag Tag { set; get; }
    }
}
