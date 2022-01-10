using ASPNET.Models;
using System.Collections.Generic;


namespace ASPNET
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
