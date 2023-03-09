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
        ApiDbContext _dbcontext = new ApiDbContext();



        //GET Methods
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbcontext.Categories);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _dbcontext.Categories.FirstOrDefault(x => x.Id == id);
            return Ok(category);
        }

        //POST Method
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _dbcontext.Categories.Add(category);
            _dbcontext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        //PUT Method
        [HttpPut("{id}")]
        public IActionResult Put (int id , [FromBody] Category categoryObj)
        {
            var category = _dbcontext.Categories.Find(id);
            category.Name = categoryObj.Name;
            category.ImageUrl = categoryObj.ImageUrl;
            _dbcontext.SaveChanges();
            return Ok("Record updated successfully");
        }

        //DELETE Method
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            var category = _dbcontext.Categories.Find(id);
            _dbcontext.Categories.Remove(category);
            _dbcontext.SaveChanges();
            return Ok("Record deleted");
        }







        //GET Methods
        //[HttpGet]
        //public IEnumerable<Category> Get()
        //{
        //    return _dbcontext.Categories;
        //}

        //[HttpGet("{id}")]
        //public Category Get(int id)
        //{
        //    var category = _dbcontext.Categories.FirstOrDefault(x => x.Id == id);
        //    return category;
        //}

        ////POST Method
        //[HttpPost]
        //public void Post([FromBody] Category category)
        //{
        //    _dbcontext.Categories.Add(category);
        //    _dbcontext.SaveChanges();
        //}

        ////PUT Method
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Category categoryObj)
        //{
        //    var category = _dbcontext.Categories.Find(id);
        //    category.Name = categoryObj.Name;
        //    category.ImageUrl = categoryObj.ImageUrl;
        //    _dbcontext.SaveChanges();
        //}

        ////DELETE Method
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var category = _dbcontext.Categories.Find(id);
        //    _dbcontext.Categories.Remove(category);
        //    _dbcontext.SaveChanges();
        //}



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
