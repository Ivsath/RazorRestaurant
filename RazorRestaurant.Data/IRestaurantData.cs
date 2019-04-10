using System.Collections.Generic;
using RazorRestaurant.Core;

namespace RazorRestaurant.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
}