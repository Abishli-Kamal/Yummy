using System.ComponentModel.DataAnnotations.Schema;

namespace TemplatePraktika.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string FoodProducts { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal Price { get; set; }
        public FoodCategory Category { get; set; }

        public int? CategoryId { get; set; }
    }
}
