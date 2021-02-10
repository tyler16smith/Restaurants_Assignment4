using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Restaurants.Models
{
    public class AllRestaurants
    {
        // Create a new static list from the new data entry from "NewRestaurants"
        private static List<NewRestaurants> TempRestData = new List<NewRestaurants>();

        // add on the data to the bigger list
        public static IEnumerable<NewRestaurants> FullRestList => TempRestData;

        // add the new restaurant suggestion to the list
        public static void AddApplication(NewRestaurants newRest)
        {
            TempRestData.Add(newRest);
        }
    }
}
