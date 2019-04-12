using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurant.Core;
using RazorRestaurant.Data;

namespace RazorRestaurant.Pages.Restaurants
{
    public class Delete : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        
        public Restaurant Restaurant { get; set; }

        public Delete(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetById((restaurantId));
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(int restaurantId)
        {
            var restaurant = _restaurantData.Delete(restaurantId);
            _restaurantData.Commit();
            if (restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{restaurant.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}