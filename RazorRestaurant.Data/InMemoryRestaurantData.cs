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
                new Restaurant { Id = 1, Name = "Irvins", Location = "Austin, TX", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 1, Name = "Boggs home", Location = "Peru", Cuisine = CuisineType.Indian }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in _restaurants orderby r.Name select r;
        }
    }
}