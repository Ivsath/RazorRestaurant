using System.Collections.Generic;
using RazorRestaurant.Core;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace RazorRestaurant.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RazorRestaurantDbContext _db;

        public SqlRestaurantData(RazorRestaurantDbContext db)
        {
            _db = db;
        }

        public int GetCountOfRestaurants()
        {
            return _db.Restaurants.Count();
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public Restaurant Create(Restaurant newRestaurant)
        {
            _db.Add(newRestaurant);
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if (restaurant != null)
            {
                _db.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return _db.Restaurants.Find(id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in _db.Restaurants
                        where string.IsNullOrEmpty(name) || r.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)
                        orderby r.Name
                        select r;
            return query;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = _db.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}