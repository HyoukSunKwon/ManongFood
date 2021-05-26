﻿using ManongFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManongFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
             new Restaurant { Id = 1 , Name = "Scott's Pizza", Cuisine =  CuisineType.Italian },
             new Restaurant { Id = 2 , Name = "Tersig", Cuisine =  CuisineType.French },
             new Restaurant { Id = 3 , Name = "Mango Grove", Cuisine =  CuisineType.Indian },
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}