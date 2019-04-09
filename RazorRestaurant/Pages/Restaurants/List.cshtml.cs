using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorRestaurant.Core;
using RazorRestaurant.Data;

namespace RazorRestaurant.Pages.Restaurants
{
    public class List : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public List(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        
        public void OnGet()
        {
            Restaurants = _restaurantData.GetAll();
        }
    }
}