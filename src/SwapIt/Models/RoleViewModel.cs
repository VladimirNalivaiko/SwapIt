using System.ComponentModel.DataAnnotations;

namespace SwapIt.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }
}