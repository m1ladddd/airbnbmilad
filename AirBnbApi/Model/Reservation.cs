using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbApi.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Location.Id")]
        public int LocationId { get; set; }
        [Required]
        public float Discount { get; set; }
        [ForeignKey("Customer.Id")]
        public int CustomerId { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
    }
}
