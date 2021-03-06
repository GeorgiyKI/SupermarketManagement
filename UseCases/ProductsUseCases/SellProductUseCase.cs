using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(
            IProductRepository productRepository,
            IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute(string cashierName, int productId, int qtyToSell, bool isForSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            if (isForSell == false)
            {
                recordTransactionUseCase.Execute(cashierName, productId, qtyToSell, false);
            }
            else
            {
                product.Quantity -= qtyToSell;
                productRepository.UpdateProduct(product);
                recordTransactionUseCase.Execute(cashierName, productId, qtyToSell, true);
            }           
        }
    }
}
