using System;
using System.Collections.Generic;

namespace SwaggerDemo.Services;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    Product FindById(Guid id);
    Product AddProduct(string productName, decimal price, string category);
    bool Delete(Guid id);
}