using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewProductsByCategoryName
    {
        IEnumerable<Product> Execute(string categoryName);
    }
}