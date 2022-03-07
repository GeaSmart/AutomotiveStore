using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)        
        {
            entityBuilder.HasIndex(x=>x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            SeedData(entityBuilder);
        }

        private void SeedData(EntityTypeBuilder entityTypeBuilder)
        {
            List<Product> products = new List<Product>();
            var random = new Random();

            for(int i = 1; i <= 100; i++)
            {
                var product = new Product {ProductId = i, Name = $"nombre {i}", Description = $"descripcion {i}", Price = random.Next(1, 300) };
                products.Add(product);
            }

            entityTypeBuilder.HasData(products);
        }
    }
}
