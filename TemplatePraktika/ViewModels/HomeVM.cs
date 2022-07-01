using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplatePraktika.Models;

namespace TemplatePraktika.ViewModels
{
    public class HomeVM
    {
       public Image  Images { get; set; }
        public About Abouts { get; set; }
        public  List<AboutCard> AboutCards { get; set; }
        public AboutCardOne AboutCardones { get; set; }

        public List<Food> Foods { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }

    }
}
