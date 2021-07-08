using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Database
{
    public class DbObjects
    {
        public static void Initial(AppDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                dbContext.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!dbContext.Vehicles.Any())
            {
                dbContext.AddRange(
                    new Vehicle
                    {
                        Name = "BMW X1",
                        Description = "В ожидании знаковых событий: новый BMW X1 появился, чтобы задавать новые стандарты. Его стремление действовать выражается прежде всего в спортивном дизайне.\n\n" +
                        "В автомобиле сразу угадывается представитель семейства X: среди внешних особенностей обращают на себя внимание короткие свесы и длинная колесная база," +
                        "ставшие неотъемлемыми чертами автомобилей класса SAV(Sports Activity Vehicle).\n\n" +
                        "Внешность,динамика и маневренность модели не оставляют сомнений в ее амбициях,а сочетание высокой практичности и универсальности" +
                        "с инновационными технологиями гарантирует максимальный комфорт, километр за километром.",
                        Category = Categories["X"],
                        Price = 2480000,
                        Specifications = "Мощность двигателя: 140 л.с\nРасход топлива: 6,2 л/100 км\nРазгон (0–100 км/ч): 9,6 с",
                        Img = "/img/BMWX1Front.jpg",
                        TopImg= "/img/X1Top.jpg"
                    },
                    new Vehicle
                    {
                        Name = "BMW 320d",
                        Description = "Едва выехав на дорогу, новый BMW 3 серии оставляет позади предрассудки и опережает самые смелые ожидания." +
                        "В очередной раз легендарная модель является в новой ипостаси.Новый дизайн символизирует наступление новой эры.\n\n" +
                        "В движение совершенный спортивный седан приводится еще более мощными и экономичными двигателями.\n\n" +
                        "Новое решение: достаточно сказать: «ОК, BMW», — после чего новый автомобиль BMW 3 серии начнет распознавать голос и практически предугадывать ваши желания.",
                        Category = Categories["3"],
                        Price = 3700000,
                        Specifications = "Мощность двигателя: 156 л.с\nРасход топлива: 6,3 л/100 км\nРазгон (0–100 км/ч): 8,4 с",
                        Img = "/img/BMW3SERIESFront.jpg",
                        TopImg = "/img/3Top.jpg"
                    },
                    new Vehicle
                    {
                        Name = "BMW IX",
                        Description = "Видение, воплотившееся в реальность.Определение электромобильности.Благодаря высокоэффективной технологии BMW eDrive и полностью электрическому приводу" +
                        " BMW iX обладает внушительным запасом хода и впечатляющей динамикой разгона с места.Его интеллектуальная операционная система BMW 8 поддерживает функцию автоматического" +
                        " обновления до самой актуальной версии и отличается максимально интуитивным управлением.",
                        Category = Categories["I"],
                        Price = 8500000,
                        Specifications = "Запас хода 630 км\nРазгон (0–100 км/ч): 4,6 с",
                        Img = "/img/BMWIXFront.jpg",
                        TopImg = "/img/IXTop.jpg"
                    },
                    new Vehicle
                    {
                       Name = "BMW M5",
                       Description = "Автомобили M BMW 5 серии впечатляющим образом сочетают в себе фирменную спортивность BMW M с комфортом и элегантностью седана бизнес-класса." +
                       " Познакомьтесь с тремя уникальными автомобилями BMW M с яркими характерами. Быстрейший в истории, новый BMW M5 CS с двигателем мощностью в 635 л.с. (467 кВт) и разгоном до 100 км/ч за рекордные 3 секунды." +
                       " Оснащенный двигателем мощностью 625 л.с. (460 кВт) и подвеской с гоночными настройками BMW M5 Competition с системой полного привода M xDrive олицетворяет собой эталон динамики." +
                       " Во внешнем облике высокомощного спортивного седана это проявляется за счет множества элементов цвета \"Глянцевый Черный\". " +
                       "В дополнение к системе полного привода M xDrive, спроектированной для максимальной динамики и устойчивости, BMW M5 оснащается подвеской, обеспечивающей спортивность и комфорт даже" +
                       " в продолжительных поездках. Завершает тройку BMW M550i xDrive. Этот ",
                       Category = Categories["M"],
                       Price = 9600000,
                       Specifications ="Мощность двигателя: 625 л.с.\nРасход топлива: 10,6 л/100 км\nРазгон (0–100 км/ч): 3,3 с",
                       Img = "/img/BMWM5Front.png",
                       TopImg = "/img/XM5Top.jpg"
                    }                     
                    ) ;
            }
            dbContext.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "X"},
                        new Category { Name = "2" },
                        new Category { Name = "3"},
                        new Category { Name = "4"},
                        new Category { Name = "5"},
                        new Category { Name = "6"},
                        new Category { Name = "7"},
                        new Category { Name = "8"},
                        new Category { Name = "Z"},
                        new Category { Name = "M"},
                        new Category { Name = "I"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.Name, item);
                    }
                }
                return category;
            }
        }
    }
}
