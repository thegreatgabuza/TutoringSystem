using System.ComponentModel.DataAnnotations;

public class Apply
{
    public class Tutor
    {
        [Required]
        [Display(Name = "Tutor Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tutor Surname")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }

    // CV as a private variable.
    private IFormFile _cv;

    [Required]
    [Display(Name = "CV")]
    [AllowedExtensions(new[] { ".pdf", ".docx", ".doc" })]

    public IFormFile CV
    {
        get { return _cv; }
        set { _cv = value!; } // Add the '!' symbol to make the parameter non-nullable.
    }
}

public class AllowedExtensionsAttribute : ValidationAttribute
{
    private readonly string[] _allowedExtensions;

    public AllowedExtensionsAttribute(string[] allowedExtensions)
    {
        _allowedExtensions = allowedExtensions;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            if (!_allowedExtensions.Contains(extension))
            {
                return new ValidationResult($"The file extension must be one of the following: {string.Join(", ", _allowedExtensions)}");
            }
        }

        return ValidationResult.Success;
    }
}
