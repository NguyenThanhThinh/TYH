using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class ProductTag : DomainEntity<int>
    {
        public int ProductId { get; set; }

      
        [Column(TypeName = "varchar(50)")]
        public string TagId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
