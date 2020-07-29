using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable]
    public class Book
    {
        public Book(string title, List<String> author, string category, int year, int price)
        {
            this.Title = title;
            this.Authors = author;
            this.Year = year;
            this.Price = price;
            this.Category = category;
        }

        public Book() { Authors = new List<string>(); }

        public string Category { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }


    }
}