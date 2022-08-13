using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CorsAPI.Controllers
{
    [ApiController]
    [DisableCors]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
       
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> productList = new List<Product>();

            productList.Add(new Product { ID = 1, Name = "Toothpaste", Expiry = 2024 });
            productList.Add(new Product { ID = 2, Name = "Brush", Expiry = 2022 });
            productList.Add(new Product { ID = 3, Name = "Soap", Expiry = 2023 });
            productList.Add(new Product { ID = 4, Name = "Biscuit", Expiry = 2024 });
            productList.Add(new Product { ID = 5, Name = "Honey", Expiry = 2022 });

            return productList.ToArray();

        }
    }
}