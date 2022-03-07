using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            // seeding some data
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Плаванье", Description = "Плаванье" },
                    new Category { CategoryId = 2, Name = "Футбол", Description = "Футбол" },
                    new Category { CategoryId = 3, Name = "Атлетика", Description = "Атлетика" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "Стартовая тумба ПТК СПОРТ Чемпион 2А", Quantity = 100, Price = 350, Desctiption= "Тумба со стартовой колодкой, соответствует новым стандартам Fina Стартовые тумбы используются для соревнований по плаванию. Основание, стойка и опора площадки выполнены из нержавеющей стали, регулируемая стартовая площадка изготовлена из стекловолокна с противоскользящей поверхностью" },
                    new Product { ProductId = 2, CategoryId = 1, Name = "Трамплинная доска Duraflex Maxi", Quantity = 200, Price = 1650, Desctiption = "Duraflex 16' Maxiflex model B (либо Maxi-B) – трамплинная доска, используемая на всех основных мировых соревнованиях. Изготовлена из дюралюминиевого сплава с перфорацией (189 отверстий, которые увеличивают эластичность и снижают вес доски)." },
                    new Product { ProductId = 3, CategoryId = 2, Name = "Настольный футбол RS 1458 Premium", Quantity = 300, Price = 660, Desctiption = "Настольный футбол RS 1458 создан для тех кто любит классику. Приятные сочетания цветов дерева (темное и белое)сделают игровой стол более элегантным, а также подчеркнут ваш замечательный выбор в пользу RS 1458." },
                    new Product { ProductId = 4, CategoryId = 2, Name = "Ворота футбольные Sport System", Quantity = 300, Price = 1200, Desctiption = "Пара футбольных ворот официальных размеров согласно EN 748 Изготовлены из армированных алюминиевых профилей овального сечения 120x100 мм. Усиленные угловые соединения." },
                    new Product { ProductId = 5, CategoryId = 3, Name = "Линейка для тройного прыжка и прыжка в длину", Quantity = 300, Price = 425, Desctiption = "Применяется для обозначения (замера) длинны прыжка, устанавливается вдоль прыжковой ямы." },
                    new Product { ProductId = 6, CategoryId = 3, Name = "Тумба-маркер", Quantity = 300, Price = 50, Desctiption = "Может применяться для обозначения номера беговой дорожки на стадионах открытого и закрытого типа. Так же может применяться для обозначения расстояния (длинны) в видах спорта где это необходимо (метания диска, молота, копья,  толкания ядра и др)." }
                );
        }
    }
}
