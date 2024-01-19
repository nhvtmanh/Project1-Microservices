using Microsoft.AspNetCore.Mvc;
using Product_service.Models;
using Product_service.Services;

namespace Product_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;

        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return productService.GetProductById(id);
        }

        [HttpPost]
        public Product AddProduct(Product product)
        {
            return productService.AddProduct(product);
        }

        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return productService.DeleteProduct(id);
        }
    }
}
