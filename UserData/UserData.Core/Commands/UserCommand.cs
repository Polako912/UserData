using System.ComponentModel.DataAnnotations;

namespace UserData.Core.Commands
{
    public class UserCommand
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int StreetNumber { get; set; }
        [Required]
        public string TelephoneNumber{ get; set; }
    }
}
