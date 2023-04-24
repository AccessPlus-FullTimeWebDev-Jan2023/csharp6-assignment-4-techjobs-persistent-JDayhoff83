using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name of Employer is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employer Name should be between 3 and 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Location of Employer is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location should be between 3 and 50 characters.")]
        public string? Location { get; set; }
    }
}
