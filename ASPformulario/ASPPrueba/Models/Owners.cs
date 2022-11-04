using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPPrueba.Models
{
    public class Owners
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string driverLicense { get; set; }
    }
}
