using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.DTOs.Product;
using Services.Interfacces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("")]
        public async Task<ActionResult<List<ProductGridItemDTO>>> GetAll()
        {
            return Ok(await _productsService.GetAll());
        }


        [HttpPost("")]
        public async Task<ActionResult> Post([FromBody] ProductDTO dto)
        {
            await _productsService.Create(dto);
            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(long id, [FromBody] ProductDTO dto)
        {
            if (!await _productsService.Exists(id)) return NotFound();
            await _productsService.Update(id, dto);
            return Ok();
        }
    }
}
