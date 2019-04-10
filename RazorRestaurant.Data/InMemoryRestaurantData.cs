using System;
using System.Collections.Generic;
using System.Linq;
using RazorRestaurant.Core;

namespace RazorRestaurant.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
        
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Giovanni's Pizza", Location = "Mexico City", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Irvins", Location = "Austin, TX", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Boggs home", Location = "Peru", Cuisine = CuisineType.Indian }
            };
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in _restaurants
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)
                orderby r.Name
                select r;
        }

        public Restaurant GetById(int id)
        {
            return _restaurants.SingleOrDefault(r => r.Id == id);
        }
    }
}
