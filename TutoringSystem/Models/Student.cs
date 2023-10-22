using System.ComponentModel.DataAnnotations;

namespace TutoringSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        [StringLength(50)]
        public string StudName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50)]
        public string Password { get; set; }

       public ICollection<Booking> Bookings { get; set; }
        

    }
}
