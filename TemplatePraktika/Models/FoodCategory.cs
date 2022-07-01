using System.Collections.Generic;

namespace TemplatePraktika.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Food> Food { get; set; }


    }
}
