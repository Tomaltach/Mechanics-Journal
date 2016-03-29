using System.ComponentModel.DataAnnotations;

namespace Tomaltach.MechanicsJournal.Entity.Models.User
{
    public class UserRoleModel
    {
        /// <summary>
        /// Role Id.
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "A valid User Id is required.")]
        public int Id { get; set; }

        /// <summary>
        /// Role Name.
        /// </summary>
        public string Name { get; set; }
    }
}
