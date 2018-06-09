using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYH.Domain.Entities
{
    public class Permission : DomainEntity<int>
    {
        public Permission()
        {

        }
        public Permission(Guid roleId, string functionId, bool canCreate,
            bool canRead, bool canUpdate, bool canDelete)
        {
            RoleId = roleId;
            FunctionId = functionId;
            CanCreate = canCreate;
            CanRead = canRead;
            CanUpdate = canUpdate;
            CanDelete = canDelete;
        }
        [Required]
        public Guid RoleId { get; set; }

        [StringLength(128)]
        [Required]
        public string FunctionId { get; set; }

        public bool CanCreate { set; get; }

        public bool CanRead { set; get; }

        public bool CanUpdate { set; get; }

        public bool CanDelete { set; get; }


        [ForeignKey(nameof(Role))]
        public virtual Role Role { get; set; }

        [ForeignKey(nameof(Function))]
        public virtual Function Function { get; set; }
    }
}
