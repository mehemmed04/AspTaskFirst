using ASPTask1.Entities;
using System.Collections.Generic;

namespace AspTaskFirst.Models
{
    public class MainViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<HotMeal> HotMeals { get; set; }
        public List<FastFood> FastFoods { get; set; }

    }
}
