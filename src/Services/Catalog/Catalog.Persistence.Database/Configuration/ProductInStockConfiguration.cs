using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductInStockId);
            entityBuilder.Property(x => x.ProductId).IsRequired();
            entityBuilder.Property(x => x.Stock).IsRequired();

            SeedData(entityBuilder);
        }

        private void SeedData(EntityTypeBuilder entityTypeBuilder)
        {
            List<ProductInStock> stocks = new List<ProductInStock>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                var stock = new ProductInStock { ProductInStockId = i, ProductId = i, Stock = random.Next(0, 500) };
                stocks.Add(stock);
            }

            entityTypeBuilder.HasData(stocks);
        }
    }
}
