using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProjekt_Beispiel.Models;
using WebProjekt_Beispiel.Models.db;
using System.Data.Common;

namespace WebProjekt_Beispiel.Controllers
{
    public class ShopController : Controller
    {
        IRepositoryArticle rep = new RepositoryArticle();

        // wird Index() aufgerufen, sollen alle Artikel angezeigt werden
        public IActionResult Index()
        {
            try {
                rep.Open();
                return View(rep.GetAllArticles());
            } catch (Exception ex)
            {
                return View("Message", new Message("Datenbakfehler", ex.Message));
            }
            finally
            {
                rep.Close();
            }
        }

        public IActionResult ReturnArticles()
        {
            return View();
        }

        // HttpGet ... dise Methode wird aufgerufen, falls ein Link angeklickt wird (GET)
        [HttpGet]
        public IActionResult CreateNewArticle()
        {
            // rufen die zugehörige View auf und übergeben einen leeren Artikel
            // aufgrund dieses Artiekels werden dann die Forumalrfelder erzeugt
            return View(new Article());
        }

        // HttpPost ... dise Methode wird aufgerufen, falls das Formular mit POST abgesendet wurde
        // newArticle ... wenn das Formular abgesendet wird, wwerden die Eingabefelder den Feldern der Klasse zugewiesen
        // (es wird auf den Namen des Feldes geachtet)
        [HttpPost]
        public IActionResult CreateNewArticle(Article newArticle)
        {
            // Parameter überprüfen
            if (newArticle == null)
            {
                return RedirectToAction("createNewArticle");
            }

            // Eingabe des Butzers überprüfen
            ValidateArticleData(newArticle);

            // falls valid -> Daten in einer DB-Tabelle abspeicern
            if (ModelState.IsValid)
            {

                 try
                {
                    // Daten in DB-Tabelle eintragen
                    // DB-Verbindung öffnen
                    rep.Open();

                    // Artikeldaten in die DB-Tabelle eintragen
                    if (rep.Insert(newArticle))
                    {
                        // Erfolgsmeldung ausgeben
                        return View("Message", new Message("Datenbank-Erfolgt",
                            "Der Artikel wurde erfolgreich abgespeichert!"));
                    }

                }
                catch (DbException)
                {
                    // Fehlermeldung ausgeben
                    return View("Message", new Message("Datenbank-Fehler", 
                        "Der Artikel konnte nicht abgespeichert werden!",
                        "Probieren Sie es bitte später erneut!"));
                }
                finally
                {
                    // DB-Verbindung schließen
                    rep.Close();
                }


                // falls die Eingaben richtig sind -> redirect zu Home/Index
                // ToDo: wir werden nächste Woche eine eigene Meldungsseite erzeugen
                return RedirectToAction("index", "home");
            }

            // falls invalid -> das Formular mit den eigenen Daten anzeigen
            return View(newArticle);
        }


        public IActionResult Delete(int id)
        {
            try
            {
                rep.Open();

                if (rep.Delete(id))
                {
                    return View("Message", new Message("Datebank", "Der Artikel wurde gelöscht!"));
                } else
                {
                    return View("Message", new Message("Datebank", "Der Artikel konnte nicht gelöscht werden!"));
                }
            }
            catch (Exception ex)
            {
                return View("Message", new Message("Datenbakfehler", ex.Message));
            }
            finally
            {
                rep.Close();
            }
        }

        private void ValidateArticleData(Article a)
        {
            if (a == null)
            {
                return;
            }

            // if (a.Articlename == null) {
            //      a.Articlename = "";
            // }
            a.Articlename = a.Articlename ?? "";

            // der Artikelname muss mind. 3 Zeichen lang sein
            if (a.Articlename.Length < 3)
            {
                //                          Name des Feldes             die anzuzeigende Fehlermeldung
                ModelState.AddModelError(nameof(Article.Articlename), "Artikelname muss mind. 3 Zeichen lang sein!");
            }
            if (a.Price < 0.0m)
            {
                ModelState.AddModelError(nameof(Article.Price), "Der Artikelpreis muss positiv sein!");
            }

            a.Description = a.Description ?? "";
            if (a.Description.Length < 5)
            {
                ModelState.AddModelError(nameof(Article.Description), "Die Descrition muss mind. 5 Zeichen lang sein!");
            }
        }
    }
}
