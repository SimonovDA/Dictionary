using System.ComponentModel.DataAnnotations;

namespace Dictionary.Web.Models
{
    public class WebUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
