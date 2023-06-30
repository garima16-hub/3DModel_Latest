using _3DModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace _3DModels.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ModelDbContext _dbContext;



        public ProductRepository(ModelDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public Product GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ModelId == id);
        }



        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }



        public void UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }



        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.ModelId == id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }



        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}