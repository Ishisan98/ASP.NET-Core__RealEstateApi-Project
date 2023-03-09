using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Data;
using RealEstateApi.Models;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ApiDbContext _dbcontext = new ApiDbContext ();

        [HttpGet]
        public IEnumerable<Category> Get() 
        {
            return _dbcontext.Categories;
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            var category = _dbcontext.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _dbcontext.Categories.Add(category);
            _dbcontext.SaveChanges();
        }
























        //private static List<Category> categories = new List<Category>()
        //{
        //    new Category () { Id = 0, Name = "Appartment", ImageUrl = "appartment.png"},
        //    new Category () { Id = 1, Name = "Commercial", ImageUrl = "commercial.png"}
        //};

        //[HttpGet]  // api/categories
        //public IEnumerable <Category> get ()
        //{
        //    return categories; 
        //}

        //[HttpPost]
        //public void Post ([FromBody] Category category)
        //{
        //    categories.Add (category);
        //}

        //[HttpPut("{id}")]
        //public void Put (int id, [FromBody] Category category)
        //{
        //    categories[id] = category;
        //}

        //[HttpDelete("{id}")]
        //public void Delete (int id)
        //{
        //    categories.RemoveAt(id);
        //}


    }
}
