using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewProductsByCategoryName : IViewProductsByCategoryName
    {
        private readonly IProductRepository productRepository;

        public ViewProductsByCategoryName(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string categoryName)
        {
            return productRepository.GetProductsByCategoryName(categoryName);
        }
    }
}
