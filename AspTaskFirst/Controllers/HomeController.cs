using ASPTask1.Entities;
using AspTaskFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspTaskFirst.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            var Drinks = new List<Drink>
                {
                    new Drink{Id=1, Name="Pepsi", Price=3.2},
                    new Drink{Id=2, Name="Ayran", Price=1.5},
                    new Drink{Id=3, Name="Sprite", Price=3.2}
                };
            return View(Drinks);
        }
        public IActionResult HotMeals()
        {
            var HotMeals = new List<HotMeal>
                {
                    new HotMeal{Id=1,Name="Plov",Price=6.8},
                    new HotMeal{Id=2,Name="Dolma",Price=5.5},
                    new HotMeal{Id=3,Name="Piti",Price=4.3},
                };
            return View(HotMeals);
        }   
        public IActionResult FastFoods()
        {
           var FastFoods = new List<FastFood>
                {
                    new FastFood{Id=1,Name="Hamburger",Price=3.6},
                    new FastFood{Id=2,Name="Sandwich",Price=2.6},
                    new FastFood{Id=3,Name="Pizza",Price=8.2},
                };
            return View(FastFoods);
        }

        public IActionResult All()
        {
            MainViewModel vm = new MainViewModel
            {
                Drinks = new List<Drink>
                {
                    new Drink{Id=1, Name="Pepsi", Price=3.2},
                    new Drink{Id=2, Name="Ayran", Price=1.5},
                    new Drink{Id=3, Name="Sprite", Price=3.2}
                },
                HotMeals = new List<HotMeal>
                {
                    new HotMeal{Id=1,Name="Plov",Price=6.8},
                    new HotMeal{Id=2,Name="Dolma",Price=5.5},
                    new HotMeal{Id=3,Name="Piti",Price=4.3},
                },
                FastFoods = new List<FastFood>
                {
                    new FastFood{Id=1,Name="Hamburger",Price=3.6},
                    new FastFood{Id=2,Name="Sandwich",Price=2.6},
                    new FastFood{Id=3,Name="Pizza",Price=8.2},
                }
            };
            return View(vm);
        }
    }
}
