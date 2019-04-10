using System.Collections.Generic;
using RazorRestaurant.Core;

namespace RazorRestaurant.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Create(Restaurant newRestaurant);
        int Commit();
    }
}