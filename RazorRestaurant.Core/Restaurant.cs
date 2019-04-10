using System.ComponentModel.DataAnnotations;

namespace RazorRestaurant.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        
        [Required, MaxLength(20)]
        public string Name { get; set; }
        
        [Required, MaxLength(40)]
        public string Location { get; set; }
        
        public CuisineType Cuisine { get; set; }
    }
}