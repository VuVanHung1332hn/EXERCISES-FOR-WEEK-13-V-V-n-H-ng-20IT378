using ASP.NET_Razor_2.Models;
using System.Collections.Generic;
using System.Linq;

public class ProductService
{
    private List<Product> products = new List<Product>();

    public ProductService()
    {
        LoadProducts();
    }

    public Product Find (int id)
    {
        var qr = from p in products
                 where p.ID == id select p;

        return qr.FirstOrDefault();
    }

    public List<Product> AllProducts() => products;
    public void LoadProducts()
    {
        products.Clear();

        products.Add(new Product()
        {
            ID = 1,
            Name = "Iphone",
            Price = 900,
            Desciption = "Điện thoại Iphone abc, xyz ..."
        });
        products.Add(new Product()
        {
            ID = 2,
            Name = "Samsung",
            Price = 800,
            Desciption = "Điện thoại Samsung, samsung điện thoại ..."
        });
        products.Add(new Product()
        {
            ID = 3,
            Name = "Nokia",
            Price = 700,
            Desciption = "Điện thoại Nokia, điện thoại Android"
        });

    }
}