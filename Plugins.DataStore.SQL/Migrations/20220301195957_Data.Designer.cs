// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQL;

namespace Plugins.DataStore.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20220301195957_Data")]
    partial class Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Плаванье",
                            Name = "Плаванье"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Футбол",
                            Name = "Футбол"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Атлетика",
                            Name = "Атлетика"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Desctiption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Desctiption = "Тумба со стартовой колодкой, соответствует новым стандартам Fina Стартовые тумбы используются для соревнований по плаванию. Основание, стойка и опора площадки выполнены из нержавеющей стали, регулируемая стартовая площадка изготовлена из стекловолокна с противоскользящей поверхностью",
                            Name = "Стартовая тумба ПТК СПОРТ Чемпион 2А",
                            Price = 350.0,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Desctiption = "Duraflex 16' Maxiflex model B (либо Maxi-B) – трамплинная доска, используемая на всех основных мировых соревнованиях. Изготовлена из дюралюминиевого сплава с перфорацией (189 отверстий, которые увеличивают эластичность и снижают вес доски).",
                            Name = "Трамплинная доска Duraflex Maxi",
                            Price = 1650.0,
                            Quantity = 200
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Desctiption = "Настольный футбол RS 1458 создан для тех кто любит классику. Приятные сочетания цветов дерева (темное и белое)сделают игровой стол более элегантным, а также подчеркнут ваш замечательный выбор в пользу RS 1458.",
                            Name = "Настольный футбол RS 1458 Premium",
                            Price = 660.0,
                            Quantity = 300
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Desctiption = "Пара футбольных ворот официальных размеров согласно EN 748 Изготовлены из армированных алюминиевых профилей овального сечения 120x100 мм. Усиленные угловые соединения.",
                            Name = "Ворота футбольные Sport System",
                            Price = 1200.0,
                            Quantity = 300
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Desctiption = "Применяется для обозначения (замера) длинны прыжка, устанавливается вдоль прыжковой ямы.",
                            Name = "Линейка для тройного прыжка и прыжка в длину",
                            Price = 425.0,
                            Quantity = 300
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Desctiption = "Может применяться для обозначения номера беговой дорожки на стадионах открытого и закрытого типа. Так же может применяться для обозначения расстояния (длинны) в видах спорта где это необходимо (метания диска, молота, копья,  толкания ядра и др).",
                            Name = "Тумба-маркер",
                            Price = 50.0,
                            Quantity = 300
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeforeQty")
                        .HasColumnType("int");

                    b.Property<string>("CashierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoldQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
