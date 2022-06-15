using Microsoft.AspNetCore.Mvc;
using Week3.Business.Abstract;
using Week3.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week3.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var p = _productService.GetById(Id);
            if (p == null)
            {
                return NotFound();
            }

            return Ok(p);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            _productService.Create(product);
            return Ok(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        public IActionResult Delete([FromBody] Product product)
        {
            _productService.Delete(product);
            return Ok("Silindi");
        }
    }
}
