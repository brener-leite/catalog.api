using Catalog.API.Context;
using Catalog.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            var categories = _context.Categories?.ToList();

            if (categories is null)
            {
                return NotFound("No categories found");
            }

            return Ok(categories);
        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        public ActionResult<Category> Get(int id)
        {
            var category = _context.Categories?.FirstOrDefault(c => c.CategoryId == id);

            if (category is null)
            {
                return NotFound($"Category with id {id} not found.");
            }

            return Ok(category);
        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Category>> GetProducts()
        {
            var categories = _context.Categories?.Include(p => p.Products).ToList();

            return Ok(categories);
        }

        [HttpPost]
        public ActionResult Post(Category category)
        {
            if (category is null)
            {
                return BadRequest();
            }

            _context.Categories?.Add(category);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCategory", new { id = category.CategoryId }, category);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Category category)
        {
            if (id !=  category.CategoryId)
            {
                return BadRequest("Id's should be the same.");
            }

            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(category);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var category = _context.Categories?.FirstOrDefault(c => c.CategoryId == id);

            if (category is null)
            {
                return NotFound($"Category with id {id} not found.");
            }

            _context.Categories?.Remove(category);
            _context.SaveChanges();

            return Ok(category);
        }
    }
}
