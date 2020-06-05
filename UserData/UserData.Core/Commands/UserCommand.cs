using System.ComponentModel.DataAnnotations;

namespace UserData.Core.Commands
{
    public class UserCommand
    {
        [Required] public string EmailAddress { get; set; }

        [Required] public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string TelephoneNumber{ get; set; }
    }
}
