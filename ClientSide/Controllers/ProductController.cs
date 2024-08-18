using ClientSide.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientSide.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await
           _productService.GetProductsAsync();
            return View(products);
        }
    }
}
