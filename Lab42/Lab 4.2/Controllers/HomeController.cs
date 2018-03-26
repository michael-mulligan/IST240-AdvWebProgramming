using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Integrated Web Solutions";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Integrated Web Solutions";

            return View();
        }

        /*** CALC APP ***/

        public ActionResult CalcApp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcApp(string ValA, string ValB, string operation)
        {
            int a = int.Parse(ValA);
            int b = int.Parse(ValB);
            int answer = 0;
            String stringAnswer;

            switch (operation)
            {
                case "add":
                    answer = a + b;
                    break;
                case "subtract":
                    answer = a - b;
                    break;
                case "multiply":
                    answer = a * b;
                    break;
                case "divide":
                    answer = a / b;
                    break;
            }

            stringAnswer = answer.ToString();
            return View("CalcApp", (object)stringAnswer);
        }
    }
}