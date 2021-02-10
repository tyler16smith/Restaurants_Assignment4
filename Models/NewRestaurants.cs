using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Restaurants.Models
{
    public class NewRestaurants
    {
        public string Name { get; set; }
        
        public string RestName { get; set; }

        public string FavDish { get; set; }

        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Please re-enter your phone number in the format (123) 456-7890")]
        public string Phone { get; set; }
    }
}
