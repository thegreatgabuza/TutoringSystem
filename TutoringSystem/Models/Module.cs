using System.ComponentModel.DataAnnotations;

namespace TutoringSystem.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }

        [Required]
        [Display(Name = "Module Name")]
        [StringLength(50)]
        public string ModuleName { get; set; }

       public ICollection<Booking> Bookings { get; set; }
        

    }
}
