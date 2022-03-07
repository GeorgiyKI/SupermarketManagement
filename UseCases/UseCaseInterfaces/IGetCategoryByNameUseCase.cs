using CoreBusiness;

namespace UseCases
{
    public interface IGetCategoryByNameUseCase
    {
        Category Execute(string categoryName);
    }
}