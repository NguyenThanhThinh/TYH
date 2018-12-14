using Microsoft.AspNetCore.Identity;
using System;

namespace TYH.Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using TYH.Domain.Enums;
    using TYH.Domain.Interfaces;
    [Table("Users")]
    public class User : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public User() { }
        public User(Guid id, string fullName, string userName,
            string email, string phoneNumber, string avatar, Status status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Avatar = avatar;
            Status = status;
        }

        public string Email { get; set; }
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
