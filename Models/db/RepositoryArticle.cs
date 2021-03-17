using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjekt_Beispiel.Models.db
{
    // die Klasse RepositoryArticle implementiert das Interface IRepositoryArticle
    //      -> dadurch muss die Klasse alle vorgegebenen Methoden ausporgrammieren
    public class RepositoryArticle : IRepositoryArticle
    {
        // die Daten des MySQL-Servers angeben
        private string _connectionString = "server=localhost;database=db_onlineshop;user=root;pwd=----";
        // Instanz für die Verbindung zum MySQL-Server
        private MySqlConnection _conn = null;

        /// <summary>
        /// diese Methode ist für das Öffnen der DB-Verbindung zuständig 
        /// </summary>
        public void Open()
        {
            if (this._conn == null)
            {
                // Verbindung wurde erzeugt
                this._conn = new MySqlConnection(this._connectionString);
            }
            // falls die Verbindung noch nicht geöffnet ist, wird sie geöffnet
            if (this._conn.State != ConnectionState.Open)
            {
                this._conn.Open();
            }
        }

        /// <summary>
        /// diese Methode ist für das Schließen der DB-Verbindung zuständig
        /// </summary>
        public void Close()
        {
            //this._conn?.Close();
            if ((this._conn != null) && (this._conn.State == ConnectionState.Open))
            {
                this._conn.Close();
            }
        }

        public bool Delete(int articleId)
        {
            if(this._conn.State == ConnectionState.Open)
            {
                DbCommand cmdDelete = this._conn.CreateCommand();
                cmdDelete.CommandText = "delete from articles where article_id = " + articleId;

                return cmdDelete.ExecuteNonQuery() == 1;
            }
            throw new Exception("Verbindung zur DB ist nicht geöffnet!");
        }

        public List<Article> GetAllArticles()
        {

            if (this._conn.State == ConnectionState.Open)
            {
                List<Article> articles = new List<Article>();

                // leeres Command erzeugen
                DbCommand cmdSelect = this._conn.CreateCommand();

                cmdSelect.CommandText = "select * from articles order by article_id";

                using (DbDataReader reader = cmdSelect.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        articles.Add(new Article
                        {
                            // article_id innerhalb der []-Klammern entspricht dem Feldname article_id
                            // in der DB-Tabelle
                            ArticleId =Convert.ToInt32(reader["article_id"]),
                            Articlename = Convert.ToString(reader["name"]),
                            Price = Convert.ToDecimal(reader["price"]),
                            Description = Convert.ToString(reader["description"]),
                            ReleaseDate = reader["releasedate"] == DBNull.Value ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["releasedate"]),
                            Category = (Category) Convert.ToInt32(reader["category"]),

                        });
                    }

                }   // an dieser Stelle wird der raeder wieder automatisch geschlossen

                if (articles.Count == 0)
                {
                    return null;
                }

                return articles;
            }
            //return null;
            throw new Exception("Datebank: Verbindung ist nicht geöffnet!");
        }


        public Article GetArticleById(int articleId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Article article)
        {
            if (article == null)
            {
                return false;
            }
            if (this._conn.State != ConnectionState.Open)
            {
                return false;
            }

            // ein leeres SQL-Command
            DbCommand cmdInsert = this._conn.CreateCommand();

            // SQL-Command (INSERT ... ) erzeugen
            //      alle Daten von außerhalb (z.B. von einem Formular) sollten als Parameter
            //      übergeben werden (Parameter beginnen mit @)
            //  => SQL-Injections werden somit verhindert
            //  SQL-Injection: hierbei wird versucht, SQL-Code (z.B.: DELETE from ) in z.B. ein 
            // Eingabefeld eines WEB-formulars einzugeben und damit ausführen zu lassen

            cmdInsert.CommandText = "insert into articles values(null, @articlename, @price, @description, @releasdate, @category);";

            // leeren Parameter erzeugen
            DbParameter paramArticlename = cmdInsert.CreateParameter();
            // ... und mit Daten füllen und mit dem Parameternamen verknüpfen 
            paramArticlename.ParameterName = "articlename";
            paramArticlename.DbType = DbType.String;
            paramArticlename.Value = article.Articlename;

            DbParameter paramPrice = cmdInsert.CreateParameter();
            paramPrice.ParameterName = "price";
            paramPrice.DbType = DbType.Decimal;
            paramPrice.Value = article.Price;

            DbParameter paramDescription = cmdInsert.CreateParameter();
            paramDescription.ParameterName = "description";
            paramDescription.DbType = DbType.String;
            paramDescription.Value = article.Description;

            DbParameter paramReleasedate = cmdInsert.CreateParameter();
            paramReleasedate.ParameterName = "releasdate";
            paramReleasedate.DbType = DbType.DateTime;
            paramReleasedate.Value = article.ReleaseDate;

            DbParameter paramCategory = cmdInsert.CreateParameter();
            paramCategory.ParameterName = "category";
            paramCategory.DbType = DbType.Int32;
            paramCategory.Value = article.Category;

            // jetzt sind alle Parameter definiert und mit dem Parametername verknüpft

            // die Parameter müssen noch der Liste "Parameters" hinzugefügt werden
            cmdInsert.Parameters.Add(paramArticlename);
            cmdInsert.Parameters.Add(paramPrice);
            cmdInsert.Parameters.Add(paramDescription);
            cmdInsert.Parameters.Add(paramReleasedate);
            cmdInsert.Parameters.Add(paramCategory);

            // nun muss der INSERT-Befehl an den DB-Server gesendet werden
            // ExecuteNonQuery() wird für insert, update, delete, ... verwendet
            // ExecuteReader() wird bei select verwendet
            return cmdInsert.ExecuteNonQuery() == 1;
            /*
            if (cmdInsert.ExecuteNonQuery() == 1)
            {
                return true;
            }  else
            {
                return false;
            }*/
        }

        public bool Update(int articleId, Article newArticleData)
        {
            throw new NotImplementedException();
        }
    }
}
