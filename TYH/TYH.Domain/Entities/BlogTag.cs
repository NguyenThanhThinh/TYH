namespace TYH.Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class BlogTag : DomainEntity<int>
    {
        public int BlogId { set; get; }

        public string TagId { set; get; }

        [ForeignKey(nameof(Blog))]
        public virtual Blog Blog { set; get; }

        [ForeignKey(nameof(Tag))]
        public virtual Tag Tag { set; get; }
    }
}
