using System;
using System.ComponentModel.DataAnnotations;

namespace SwaggerDemo.Services;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public string Category { get; private set; }
    public DateTime CreationDate { get; private set; }

    public Product(Guid id, string name, decimal price, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        CreationDate = DateTime.Now;
    }
}