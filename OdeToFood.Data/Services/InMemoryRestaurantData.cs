using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Gabriel's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Ribs&Company", Cuisine = CuisineType.American},
                new Restaurant {Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
