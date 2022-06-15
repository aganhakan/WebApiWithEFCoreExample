using Microsoft.AspNetCore.Mvc;
using Week3.Business.Abstract;
using Week3.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week3.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: api/<CategorytController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var Category = _categoryService.GetAll();
            return Ok(Category);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var p = _categoryService.GetById(Id);
            if (p == null)
            {
                return NotFound();
            }

            return Ok(p);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Create([FromBody] Category Category)
        {
            _categoryService.Create(Category);
            return Ok(Category);
        }

        // PUT api/<CategoryController>/5
        [HttpPut]
        public IActionResult Update([FromBody] Category Category)
        {
            _categoryService.Update(Category);
            return Ok(Category);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete]
        public IActionResult Delete([FromBody] Category Category)
        {
            _categoryService.Delete(Category);
            return Ok("Silindi");
        }
    }
}
