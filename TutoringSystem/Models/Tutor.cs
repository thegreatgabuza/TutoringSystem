using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutoringSystem.Models
{
    public class Tutor
    {
        [Key]
        public int TutId { get; set; }

        [Required]
        [Display(Name = "Tutor Name")]
        [StringLength(50)]
        public string TutName { get; set; }

        [Required]
        [Display(Name = "Tutor Lastname")]
        [StringLength(50)]
        public string TutLastName { get; set; }

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

        //[Required]
        //[Display(Name = "Student Name")]
        //[StringLength(50)]
        //public string Modules { get; set; }

        [Required]
        [Display(Name = "Rate Per Hour")]
        public double Rate { get; set; }

        [ForeignKey("ModuleId")]
        public int ModuleId { get; set; }
        public Module Module { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        // Private file upload property
        private IFormFile _fileUpload;

        public IFormFile FileUpload
        {
            get { return _fileUpload; }
            set { _fileUpload = value; }
        }

    }
}
