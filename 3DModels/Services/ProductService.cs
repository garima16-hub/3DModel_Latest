using _3DModels.Models;
using _3DModels.Repository;
using System.Collections.Generic;

namespace _3DModels.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;



        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }



        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }



        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }



        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }



        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
