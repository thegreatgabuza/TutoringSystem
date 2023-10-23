using System.ComponentModel.DataAnnotations;

namespace TutoringSystem.Models
{

    public class TutorCV
    {

        public int TutorCVId { get; set; }

        [Required]
        public byte[] FileContents { get; set; }

        public int TutorId { get; set; }

        public virtual Tutor Tutor { get; set; }

        // Create string array for allowed extensions
        string[] allowedExtensions = { ".pdf", ".docx" };

        // Pass array to attribute 
        [AllowedExtensions(allowedExtensions: allowedExtensions)]
        public string FileName { get; set; }

        // Add ContentType property
        public string ContentType { get; set; }

    }

}
