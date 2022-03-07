using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //Add some default categories

            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Плаванье", Description = "Плаванье" },
                    new Category { CategoryId = 2, Name = "Футбол", Description = "Футбол" },
                    new Category { CategoryId = 3, Name = "Атлетика", Description = "Атлетика" }
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return categories?.FirstOrDefault(x => x.Name == categoryName);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
