using ASP.NET_Razor_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace ASP.NET_Razor_2.Pages
{
    public class ProductPageModel : PageModel
    {
        private readonly ILogger<ProductPageModel> _logger;

        public readonly ProductService productService;
        public ProductPageModel(ILogger<ProductPageModel> logger, ProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public Product product { get; set; }

        //[FromBody]
        //[FromQuery]
        //[FromRoute]
        //[FromForm]
        //[FromHeader]  
        //[FromQuery]
        public void OnGet(int? id, [Bind("Id", "Name")] Product sanpham)
        {
            Console.WriteLine($"ID : {sanpham.ID}");
            Console.WriteLine($"ID : {sanpham.Name}");
            //var data = this.Request.Form["id"];
            // var data = this.Request.Query["id"];
            // var data = this.Request.RouteValues["id"];
            //var data = this.Request.Headers["id"];


            //if (!string.IsNullOrEmpty(data))
            // {
            //    Console.WriteLine(data.ToString());
            //    int i = int.Parse(data.ToString());
            // }


            if (id != null)
            {
                ViewData["Title"] = $"Sản phẩm (ID = {id.Value})";
                product = productService.Find(id.Value) ;
            }
            else
            {
                ViewData["Title"] = $"Danh sách sản phẩm";
            }
            
        }

        public IActionResult OnGetLastProduct() 
        {
            ViewData["Title"] = $"Sản phẩm cuối";
            product = productService.AllProducts().LastOrDefault();
            if (product != null)
            {
                return Page();
            }
            else
            {
                return this.Content("Không tìm sản phẩm");
            }
        }

        public IActionResult OnGetRemoveAll()
        {
            productService.AllProducts().Clear();
            return RedirectToPage("ProductPage");
        }

        public IActionResult OnGetLoad()
        {
            productService.LoadProducts();
            return RedirectToPage("ProductPage");
        }

        public IActionResult OnPostDelete(int? id)
        {
            if (id != null)
            {
                product = productService.Find(id.Value);
                if(product != null)
                {
                    productService.AllProducts().Remove(product);
                }
            }

            return this.RedirectToPage("ProductPage", new {id=string.Empty});

        }
    }
}

