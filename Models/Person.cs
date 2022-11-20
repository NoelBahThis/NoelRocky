using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NoelRocky.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, 4, ErrorMessage = "Year must be 0 to 4")]
        public int Year { get; set; }
    }
}
