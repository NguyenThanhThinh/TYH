using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class AnnouncementUser : DomainEntity<int>
    {
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

        [StringLength(450)]
        [Required]
        public string UserId { get; set; }

        public bool? HasRead { get; set; }

        [ForeignKey(nameof(User))]
        public virtual User User { get; set; }

        [ForeignKey(nameof(Announcement))]
        public virtual Announcement Announcement { get; set; }
    }
}
