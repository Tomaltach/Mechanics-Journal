using System.ComponentModel.DataAnnotations;
using Tomaltach.MechanicsJournal.Entity.Models.Location;

namespace Tomaltach.MechanicsJournal.Entity.Models.Person
{
    public class InfoModel
    {
        /// <summary>
        /// First Name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle Name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public AddressModel Address { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
