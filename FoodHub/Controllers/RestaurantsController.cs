using FoodHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodHub.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly List<Restaurant> restaurants = new List<Restaurant>()
        {
            new Restaurant() {Id = 1 , Name ="Ali", Cuisine = "B", DeliveryFee = 25, DeliveryMinutes = 20 , Rating = 3.5 , IsOpen = true},
            new Restaurant() {Id = 2 , Name ="Mai", Cuisine = "B22", DeliveryFee = 30, DeliveryMinutes = 20 , Rating = 2.2 , IsOpen = true},
            new Restaurant() {Id = 3 , Name ="Soly", Cuisine = "B3", DeliveryFee = 35, DeliveryMinutes = 20 , Rating = 4 , IsOpen = true},
            new Restaurant() {Id = 4 , Name ="Dalia", Cuisine = "B4", DeliveryFee = 45, DeliveryMinutes = 20 , Rating = 1.25 , IsOpen = true}
        };
        public IActionResult Index()
        {
            var Restaurants = restaurants.OrderByDescending(x => x.Rating).ToList();
            return View(Restaurants);
        }
    }
}
