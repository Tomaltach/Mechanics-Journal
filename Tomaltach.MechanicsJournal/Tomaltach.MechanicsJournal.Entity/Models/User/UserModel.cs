using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tomaltach.MechanicsJournal.Entity.Models.User
{
    public class UserModel
    {
        /// <summary>
        /// User Id.
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "A valid User Id is required.")]
        public int Id { get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// User roles.
        /// </summary>
        public IList<UserRoleModel> Roles { get; set; }
    }
}
