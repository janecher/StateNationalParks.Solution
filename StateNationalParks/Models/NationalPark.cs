using System.ComponentModel.DataAnnotations;

namespace StateNationalParks.Models
{
    public class NationalPark
    {
        public int NationalParkId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Address { get; set; }

    }
}