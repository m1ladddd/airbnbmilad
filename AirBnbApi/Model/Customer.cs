using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbApi.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
