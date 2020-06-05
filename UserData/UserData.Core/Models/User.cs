using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserData.Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required] public string EmailAddress { get; set; }

        [Required] public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string TelephoneNumber{ get; set; }
    }
}