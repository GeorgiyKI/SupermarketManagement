using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetCategoryByNameUseCase : IGetCategoryByNameUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByNameUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(string categoryName)
        {
            return categoryRepository.GetCategoryByName(categoryName);
        }
    }
}
