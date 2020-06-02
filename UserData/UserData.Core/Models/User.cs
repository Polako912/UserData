using System.ComponentModel.DataAnnotations;

namespace UserData.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
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
    }
}
