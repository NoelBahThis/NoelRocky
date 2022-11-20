using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NoelRocky.Models
{
    public class ApplicationType
    {
          [Key]
          public int Id { get; set; }

          [Required]
          public string Name { get; set; }
     }
}
