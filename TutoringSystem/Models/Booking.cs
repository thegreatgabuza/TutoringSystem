using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutoringSystem.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Tutor")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }

        [ForeignKey("Module")]
        public int? ModuleId { get; set; }
        public Module Module { get; set; }

        [Display(Name = "Start Date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime EndDate { get; set; }

        public string Status { get; set; }
    }
}
