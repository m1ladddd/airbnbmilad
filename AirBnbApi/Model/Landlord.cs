using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbApi.Model
{
    public class Landlord
    {
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
        public Image Avatar { get; set; }
        public ICollection<Location> Locations { get; set; }
        [ForeignKey("Picture.Id")]
        public int AvatarId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
