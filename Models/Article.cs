using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjekt_Beispiel.Models
{

    public enum Category
    {
        Books, Computers, Technics, Handys, notSpecified
    }

    public class Article
    {
        public int ArticleId { get; set; }
        public string Articlename { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public Category Category { get; set; }

        // Custructors
        public Article() : this(0,"", 0.0m, "", null, Category.notSpecified) { }
        public Article(int id, string articlename, decimal price, string description, DateTime? releaseDate, Category category)
        {
            this.ArticleId = id;
            this.Articlename = articlename;
            this.Price = price;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Category = category;
        }

        public override string ToString()
        {
            return this.ArticleId + " " + this.Articlename + " " + this.Price + "Euro";
        }
    }
}
