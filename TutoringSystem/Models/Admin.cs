using System.ComponentModel.DataAnnotations;

namespace TutoringSystem.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [Display(Name ="Admin Name")]
        [StringLength(50)]
        public string AdminName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50)]
        public string Password { get; set; }



    }
}
