using _3DModels.Models;
using System.Collections.Generic;

namespace _3DModels.Repository
{
    public interface IProductRepository
    {
       
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        IEnumerable<Product> GetAllProducts();
    }
}
