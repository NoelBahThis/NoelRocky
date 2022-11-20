using System.ComponentModel.DataAnnotations;

namespace NoelRocky.Models
{
    public class FavFood
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public string FavFoodItem { get; set; }
    }
}
