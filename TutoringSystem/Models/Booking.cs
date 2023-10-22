using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutoringSystem.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Student")]
        [ForeignKey("StudentId")]
        public int? StudentId { get; set; }
        public Student Student { get; set; }

        [Display(Name = "Tutor")]
        [ForeignKey("TutorId")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }

        [Display(Name ="Module")]
        [ForeignKey("ModuleId")]
        public int? ModuleId { get; set; }
        public Module Module { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Venue")]
        [StringLength(50)]
        public string venue { get; set; }
    }
}
