﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Models;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private List<Category> categories = new List<Category>()
        {
            new Category () { Id = 0, Name = "Appartment", ImageUrl = "appartment.png"},
            new Category () { Id = 1, Name = "Commercial", ImageUrl = "commercial.png"}
        };


        [HttpGet]
        public IEnumerable <Category> get ()
        {
            return categories; 
        } 
    }
}
