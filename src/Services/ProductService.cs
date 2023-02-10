using System;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerDemo.Services;

public class ProductService: IProductService
{
    public static List<Product> Products = new(){
        new Product(Guid.Parse("9743ea71-b19a-4477-b6e9-30a50614115d"), "Product 1", 100, "Category 1"),
        new Product(Guid.Parse("1a6053f9-5752-46b5-8989-4b851dd84d0b"), "Product 2", 85, "Category 2"),
        new Product(Guid.Parse("e649777c-7433-4363-9cdf-88f92e006560"), "Product 3", 132, "Category 1")
    };

    #region  public methods
    public IEnumerable<Product> GetProducts()
    {
        var result = Products.AsEnumerable();
        return result;
    }

    public Product AddProduct(string name, decimal price, string category)
    {
        var product = new Product(Guid.NewGuid(), name, price, category);
        Products.Add(product);
        return product;
    }

    public Product FindById(Guid id)
    {
        var result = Products.FirstOrDefault(p=>p.Id == id);
        return result;
    }

    public bool Delete(Guid id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        return Products != null && Products.Remove(product);
    }
    #endregion
}