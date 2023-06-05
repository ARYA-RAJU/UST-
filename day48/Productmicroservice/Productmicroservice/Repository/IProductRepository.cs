using Productmicroservice.Model;
using System.Collections.Generic;
namespace Productmicroservice.Repository
{
   public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);
        void updateProduct(Product Product);
        void Save();
    }
}
