using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Restaurants.Models
{
    public class Restaurants
    {
        // sets the rank property to "Read Only"
        public Restaurants(int Ranking)
        {
            Rank = Ranking;
        }

        [Required]
        #nullable enable
        public int? Rank { get; set; }
        
        [Required]
        public string Name { get; set; }

        #nullable enable
        public string? FavDish { get; set; } = "It's all tasty!";

        [Required]
        public string Address { get; set; }

        //Validate the phone number
        [RegularExpression(@"^(\d{3})[ -]?(\d{3})[ -]?(\d{4}) x(\d*)", ErrorMessage = "Please re-enter your phone number in the format (123) 456-7890")]
        public string Phone { get; set; }

        public string? Website { get; set; } = "Coming Soon";

        public static Restaurants[] GetList()
        {
            // All restaurant data
            Restaurants R1 = new Restaurants(1)
            {
                Rank = 1,
                Name = "JJ Burgers",
                FavDish = "The $2 Hamburger",
                Address = "40 N 400 W, Provo, UT 84601",
                Phone = "(801) 691-0580",
                Website = "https://jjburgerut.com/products/items/OTIy/MzIw"
            };

            Restaurants R2 = new Restaurants(2)
            {
                Rank = 2,
                Name = "Don Chuy's",
                Address = "520 900 E, Provo, UT 84606",
                Phone = "(801) 607-1519",
                Website = "https://www.donchuys.com/"
            };

            Restaurants R3 = new Restaurants(3)
            {
                Rank = 3,
                Name = "Gurus",
                FavDish = "Sweet Potato Fries",
                Address = "44 E Center Street, Provo, UT 84601",
            };

            Restaurants R4 = new Restaurants(4)
            {
                Rank = 4,
                Name = "Don Joaquins",
                FavDish = "Carne Asada Tacos",
                Address = "150 W 1230 N St, Provo, UT 84604",
                Phone = "(801) 400-2894",
            };

            Restaurants R5 = new Restaurants(5)
            {
                Rank = 5,
                Name = "Creamery on Ninth East",
                FavDish = "Child's Meal (Burger)",
                Address = "1209 900 E, Provo, UT 84604",
                Phone = "(801) 422-2663",
                Website = "https://dining.byu.edu/creamery/"
            };

            //Return an array of objects
            return new Restaurants[] { R1, R2, R3, R4, R5 };
        }
    }
}
