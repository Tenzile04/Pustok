using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Feature
    {
        public int Id {  get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Title1 { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title2 { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
