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
                new Restaurant { Id = 1, Name = "Jeremy's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Shahibs", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 3, Name = "FrieBurgs", Cuisine = CuisineType.None}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
