using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurant.Core;
using RazorRestaurant.Data;

namespace RazorRestaurant.Pages.Restaurants
{
    public class Detail : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public Restaurant Restaurant { get; set; }
        
        [TempData]
        public string Message { get; set; }

        public Detail(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}