using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            // Init with default values
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Стартовая тумба ПТК СПОРТ Чемпион 2А", Quantity = 100, Price = 350, Desctiption= "Тумба со стартовой колодкой, соответствует новым стандартам Fina Стартовые тумбы используются для соревнований по плаванию. Основание, стойка и опора площадки выполнены из нержавеющей стали, регулируемая стартовая площадка изготовлена из стекловолокна с противоскользящей поверхностью" },
                    new Product { ProductId = 2, CategoryId = 1, Name = "Трамплинная доска Duraflex Maxi", Quantity = 200, Price = 1650, Desctiption = "Duraflex 16' Maxiflex model B (либо Maxi-B) – трамплинная доска, используемая на всех основных мировых соревнованиях. Изготовлена из дюралюминиевого сплава с перфорацией (189 отверстий, которые увеличивают эластичность и снижают вес доски)." },
                    new Product { ProductId = 3, CategoryId = 2, Name = "Настольный футбол RS 1458 Premium", Quantity = 300, Price = 660, Desctiption = "Настольный футбол RS 1458 создан для тех кто любит классику. Приятные сочетания цветов дерева (темное и белое)сделают игровой стол более элегантным, а также подчеркнут ваш замечательный выбор в пользу RS 1458." },
                    new Product { ProductId = 4, CategoryId = 2, Name = "Ворота футбольные Sport System", Quantity = 300, Price = 1200, Desctiption = "Пара футбольных ворот официальных размеров согласно EN 748 Изготовлены из армированных алюминиевых профилей овального сечения 120x100 мм. Усиленные угловые соединения." },
                    new Product { ProductId = 5, CategoryId = 3, Name = "Линейка для тройного прыжка и прыжка в длину", Quantity = 300, Price = 425, Desctiption = "Применяется для обозначения (замера) длинны прыжка, устанавливается вдоль прыжковой ямы." },
                    new Product { ProductId = 6, CategoryId = 3, Name = "Тумба-маркер", Quantity = 300, Price = 50, Desctiption = "Может применяться для обозначения номера беговой дорожки на стадионах открытого и закрытого типа. Так же может применяться для обозначения расстояния (длинны) в видах спорта где это необходимо (метания диска, молота, копья,  толкания ядра и др)." }

            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }


            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }


        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete != null) products.Remove(productToDelete);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }

        public IEnumerable<Product> GetProductsByCategoryName(string categoryName)
        {
            var category = products.FirstOrDefault(x => x.Category.Name == categoryName);
            return products.Where(x => x.CategoryId == category.CategoryId).ToList();
        }
    }
}
