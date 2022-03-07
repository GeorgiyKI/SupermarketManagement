using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Плаванье", "Плаванье" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Футбол", "Футбол" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Атлетика", "Атлетика" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Тумба со стартовой колодкой, соответствует новым стандартам Fina Стартовые тумбы используются для соревнований по плаванию. Основание, стойка и опора площадки выполнены из нержавеющей стали, регулируемая стартовая площадка изготовлена из стекловолокна с противоскользящей поверхностью", "Стартовая тумба ПТК СПОРТ Чемпион 2А", 350.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Duraflex 16' Maxiflex model B (либо Maxi-B) – трамплинная доска, используемая на всех основных мировых соревнованиях. Изготовлена из дюралюминиевого сплава с перфорацией (189 отверстий, которые увеличивают эластичность и снижают вес доски).", "Трамплинная доска Duraflex Maxi", 1650.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Настольный футбол RS 1458 создан для тех кто любит классику. Приятные сочетания цветов дерева (темное и белое)сделают игровой стол более элегантным, а также подчеркнут ваш замечательный выбор в пользу RS 1458.", "Настольный футбол RS 1458 Premium", 660.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Пара футбольных ворот официальных размеров согласно EN 748 Изготовлены из армированных алюминиевых профилей овального сечения 120x100 мм. Усиленные угловые соединения.", "Ворота футбольные Sport System", 1200.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Desctiption", "ImageData", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 5, 3, "Применяется для обозначения (замера) длинны прыжка, устанавливается вдоль прыжковой ямы.", null, "Линейка для тройного прыжка и прыжка в длину", 425.0, 300 },
                    { 6, 3, "Может применяться для обозначения номера беговой дорожки на стадионах открытого и закрытого типа. Так же может применяться для обозначения расстояния (длинны) в видах спорта где это необходимо (метания диска, молота, копья,  толкания ядра и др).", null, "Тумба-маркер", 50.0, 300 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Beverage", "Beverage" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Bakery", "Bakery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Meat", "Meat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "What", "Iced Tea", 1.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "about", "Canada Dry", 1.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "What", "Whole Wheat Bread", 1.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "about", "White Bread", 1.5 });
        }
    }
}
