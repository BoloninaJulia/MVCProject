using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
        public ActionResult Info()
        {
            DB.DBModel db = new DB.DBModel();
            List<Models.Info> list = new List<Models.Info>();
            var query = from i1 in db.Company join i2 in db.User on i1.ID equals i2.IDCompany
                        orderby i1.Name select new {company=i1.Name, user=i2.Name, status=i2.StatusContract };
            foreach (var a in query)
            {
                Models.Info item = new Models.Info()
                {
                    Name = a.company,
                    User=a.user,
                    Status=a.status

                };
                list.Add(item);
            }

            return View("Info", list);
        }
        public ActionResult Company()
        {
            DB.DBModel db = new DB.DBModel();
            List<Models.Company> list = new List<Models.Company>();
            var query = from i1 in db.Company
                        orderby i1.Name
                        select i1;
            foreach (var a in query)
            {
                Models.Company item = new Models.Company()
                {
                    ID=a.ID,
                    Name = a.Name

                };
                list.Add(item);
            }

            return View("Company", list);
        }
        public ActionResult CreateCompany()
        {
            return View();
        }
        /// <summary>
        /// Создание книги
        /// </summary>
        /// <param name="collection">Набор параметров</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateCompany(FormCollection collection)
        {
            DB.DBModel db = new DB.DBModel();
            DB.Company c = new DB.Company()
            {
                Name = collection["Name"]
            };
            db.Company.Add(c);
            db.SaveChanges();
            return RedirectToAction("CreateCompany");
        }
        public ActionResult DeleteCompany(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                // Молча вернуться в список
                return RedirectToAction("Company");
            }

            int ID = int.Parse(id);
            DB.DBModel db = new DB.DBModel();
            DB.Company c= (from item in db.Company where item.ID == ID select item).FirstOrDefault();
            return View(c);
        }
        [HttpPost]
        public ActionResult DeleteCompany(string id, FormCollection collection)
        {
            int ID = int.Parse(id);
           
            DB.DBModel db =new  DB.DBModel();
            var query = from item in db.Company where item.ID ==ID  select item;
            db.Company.RemoveRange(query);
            db.SaveChanges();
            return RedirectToAction("Company");
        }
        public ActionResult ChangeCompany(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                // Молча вернуться в список
                return RedirectToAction("Company");
            }
            int ID = int.Parse(id);
            DB.DBModel db = new DB.DBModel();
            DB.Company c = (from item in db.Company where item.ID == ID select item).FirstOrDefault();
            return View(c);
        }
        [HttpPost]
        public ActionResult ChangeCompany(FormCollection collection)
        {
            int ID = int.Parse(collection["ID"]);
            DB.DBModel db = new DB.DBModel();
            DB.Company c = (from item in db.Company where item.ID == ID select item).FirstOrDefault();
            c.Name = collection["Name"];
            db.SaveChanges();
            return RedirectToAction("Company");
        }
    }
}