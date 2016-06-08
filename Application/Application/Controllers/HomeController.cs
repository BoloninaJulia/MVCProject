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
        public ActionResult V()
        {


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
    }
}