using System.ComponentModel.DataAnnotations;

namespace RealEstateApi.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required (ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }

        [Required (ErrorMessage = "ImageUrl cannot be empty")]
        public string ImageUrl { get; set; }

    }
}
