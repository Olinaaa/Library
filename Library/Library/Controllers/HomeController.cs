using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        List<Models.Reserve> resev = new List<Models.Reserve>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        Книжная_библиотекаContext db = new Книжная_библиотекаContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(Книги log)
        {
            string n = log.НазваниеКниги;            
            Книги inf = db.Find<Книги>(n);

            if (inf == null)
            {
                ViewData["Message"] = "В библитеке нет этой книги!";
                return View();
            }
            else
            {
                Reserve b1 = new Reserve();
                b1.КодКниги = inf.КодКниги;
                b1.ФиоАвтора = inf.ФиоАвтора;
                resev.Add(b1);
                string a = "Код:" + Convert.ToString(inf.КодКниги) +"   \n"
                           + "Автор: "+inf.ФиоАвтора + "   Название: " + inf.НазваниеКниги + "\n" +
                           "   Год: " + Convert.ToString(inf.Год);

                ViewData["Message"] =a ;
                return View();
            }
        }

        public IActionResult Info()
        {
            
            return View(db.Книгиs);
        }

        public IActionResult Authors()
        {
            return View(db.Авторыs);
        }
        public IActionResult Person(Авторы av)
        {
            string n = av.ФиоАвтора;
            Авторы inf = db.Find<Авторы>(n);

            if (inf == null)
            {
                if (av.ФиоАвтора != null)
                    ViewData["Message"] = "В библитеке нет книг этого автора!";
                return View();
            }
            else
            {
                string a = "Код:" + Convert.ToString(inf.КодАвтора) + "   \n"
                           + "ФИО: " + inf.ФиоАвтора + "   ДР: " + Convert.ToString(inf.ДеньРождения) + "\n" +
                           "   Страна: " + inf.Страна;

                ViewData["Message"] = a;
                return View();
            }
        }

        public IActionResult AddBook(Книги book)
        {
            string Fio = book.ФиоАвтора;
            string name = book.НазваниеКниги;
            if (Fio != null && db.Find<Авторы>(Fio) != null && db.Find<Книги>(name) == null)
            {
                Книги book2 = new Книги();
                book2.КодКниги = Convert.ToInt32(book.КодКниги);
                book2.Год = Convert.ToInt32(book.Год);
                book2.НазваниеКниги = name;
                book2.ФиоАвтора = Fio;
                db.Книгиs.Add(book2);
                db.SaveChanges();
                ViewData["Message"] = "Книга добавлена!";
                return View();
            }
            else
            {
                if (book.НазваниеКниги !=null)
                ViewData["Message"] = "Невозможно добавить книгу!";
                return View();
            }
        }

        public IActionResult AddAuthor(Авторы AV)
        {
            string Fio = AV.ФиоАвтора;
            if (Fio != null && db.Find<Авторы>(Fio) == null && AV.КодАвтора != 0 && AV.ДеньРождения !=null && AV.Страна != null)
            {
                    Авторы AV2 = new Авторы();
                    AV2.КодАвтора = Convert.ToInt32(AV.КодАвтора);
                    AV2.ДеньРождения = Convert.ToDateTime(AV.ДеньРождения);
                    AV2.ФиоАвтора = AV.ФиоАвтора;
                    AV2.Страна = AV.Страна;
                    db.Авторыs.Add(AV2);
                    db.SaveChanges();
                    ViewData["Message"] = "Автор добавлен!";
                    return View();
            }
            else
            {
                if (AV.ФиоАвтора != null)
                    ViewData["Message"] = "Невозможно добавить автора!";
                return View();
            }
        }
        public IActionResult DeleteAuthor(Авторы AV)
        {
            string Fio = AV.ФиоАвтора;
            if (db.Find<Авторы>(Fio) != null)
            {
                Авторы AV2 = db.Find<Авторы>(Fio);
                db.Авторыs.Remove(AV2);
                db.SaveChanges();
                ViewData["Message"] = "Автор успешно удален!";
                return View();
            }
            else
            {
                if (AV.ФиоАвтора != null)
                    ViewData["Message"] = "Невозможно удалить запись об этом авторе";
                return View();
            }
        }
        public IActionResult DeleteBook(Книги book)
        {
            string name = book.НазваниеКниги;
            if (name != null && db.Find<Книги>(name) != null)
            {
                Книги book2 = db.Find<Книги>(name);
                db.Книгиs.Remove(book2);
                db.SaveChanges();
                ViewData["Message"] = "Книга успешно удалена!";
                return View();
            }
            else
            {
                if (book.НазваниеКниги != null)
                    ViewData["Message"] = "Невозможно удалить запись об этой книге!";
                return View();
            }
        }
        public IActionResult ApdateAuthor(Авторы AV)
        {
            Авторы AV2 = db.Авторыs.Find(AV.ФиоАвтора);
            if (AV2 != null && AV.Страна != null)
            {
                AV2.Страна = AV.Страна;
                db.Авторыs.Update(AV2);
                db.SaveChanges();
                ViewData["Message"] = "Страна автора изменена!";
                return View();
            }
            else
            {
                if (AV.ФиоАвтора != null)
                ViewData["Message"] = "Страна автора не может быть изменена!"; 
                return View(); 
            }
        }

        public IActionResult ApdateBook(Книги book)
        {
            Книги book2 = db.Книгиs.Find(book.НазваниеКниги);
            if (book2 != null && book.Год != 0)
            {
                book2.Год = book.Год;
                db.Книгиs.Update(book2);
                db.SaveChanges();
                ViewData["Message"] = "Год написания книги изменен!";
                return View();
            }
            else
            {
                if (book.ФиоАвтора != null)
                    ViewData["Message"] = "Год написания книги не может быть изменен!";
                return View();
            }
        }
    }
}
