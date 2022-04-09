using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAllProducts()
        {
            var product = await _repository.FindAll();

            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> FindProductById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> CreateProduct(ProductVO productVO)
        {
            if (productVO == null) return BadRequest();

            var product = await _repository.Create(productVO);

            return Created("", product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> UpdateProduct(ProductVO productVO)
        {
            if (productVO == null) return BadRequest();

            var product = await _repository.Update(productVO);

            return Ok(product);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();

            return Ok(status);
        }
    }
}
