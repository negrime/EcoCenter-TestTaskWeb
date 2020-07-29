using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask
{
    public class BookService : IBookService
    {
        public List<Book> ReadAll()
        {
            List<Book> books = new List<Book>
            {
                new Book { Title = "Чистый пол", Category = "Домохозяйки", Price = 1500, Year = 2018, Authors = new List<string> { "Роберт Мартин" } },
                new Book { Title = "Совершенный кот", Category = "Животные", Price = 2000, Year = 2019, Authors = new List<string> { "Стив Маееонелл", "Сан Саныч" } },
                new Book { Title = "Грокаем рифмы", Category = "Поэзия", Price = 400, Year = 2015, Authors = new List<string> { "Адитья Бхаргава" } },
            };

            return books;
        }
    }
}
