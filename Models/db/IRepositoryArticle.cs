using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjekt_Beispiel.Models.db
{
    // Interface für den Zugriff auf die Artikeldaten erzeugen
    //      => dadurch werden Programme flexiebler

    // Repositry ... Ablageort
    interface IRepositoryArticle
    {

        void Open();
        void Close();

        Article GetArticleById(int articleId);
        List<Article> GetAllArticles();
        bool Insert(Article article);
        bool Delete(int articleId);
        bool Update(int articleId, Article newArticleData);
    }


}
