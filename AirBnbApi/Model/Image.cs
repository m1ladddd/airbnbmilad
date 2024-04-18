using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AirBnbApi.Model
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        public Location Location { get; set; }
        public Landlord Landlord { get; set; }
        [Required]
        public bool IsCover { get; set; }
        [ForeignKey("Location.Id")]
        public int? LocationId { get; set; }
    }
}
