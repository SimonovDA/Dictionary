using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dictionary.Data.Models
{
    public class User : BaseEntry
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
    }
}
