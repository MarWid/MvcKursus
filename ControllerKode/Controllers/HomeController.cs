using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerKode.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Test1() {

            return Content("1234");              
        }


        public ActionResult Test2()
        {

            return Content("1;2;3;4", "application/CSV"); // Kan fx også bruges til pdf
        }



        public ActionResult Test3()
        {

            return Redirect("http://google.dk");

        }



        public ActionResult Test4()
        {

            return RedirectToAction("Index");

        }





        public ActionResult Test5()
        {

            return Json(Person.Personer(), JsonRequestBehavior.AllowGet); // Bruger det nedenfor med public class Person og public static List<Person...

        }



        public ActionResult Test6()
        {

            return View();

        }


        public ActionResult Test7()
        {
            // valideringsfejl

            HttpStatusCodeResult s = new HttpStatusCodeResult(500, "Der er sket en fejl....");
            return s;
        }

        public ActionResult Test8()
        {
            string t = Guid.NewGuid().ToString();

            ViewBag.streng = t;
            ViewBag.id = 1;
            return View();
        }



        public ActionResult Test9()
        {
            string t = Guid.NewGuid().ToString();
            Test9ViewModel m = new Test9ViewModel
            {
                Id = 1,
                Streng = t
            };
            return View(m);
        }
    //public ActionResult Test10(string test, int tal) //Prøv at finde noget der hedder test10 i formen eller url og put det ind i view
            public ActionResult Test10(string test, int? tal =10) //? nullable eller =
        {

            //if (tal == null) { }
            return View();
    }

        public ActionResult Test11(Person p) //? nullable eller =
        {

            return View();
        }

        public ActionResult Test12(Person p) //? nullable eller =
        {
            if (!ModelState.IsValid) { } else { }
            return View();
        }


    }

    public class Test9ViewModel
    {
        public int Id { get; set; }
        public string Streng { get; set; }
    }










    public class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
            public int Alder { get; set; }



            public static List<Person> Personer()
            {
                List<Person> p = new List<Person>()
            {
                new Person(){ Id=1, Alder = 10, Navn = "asdf"},
                new Person(){ Id=2, Alder = 30, Navn = "sdfdfsghegsgd"},
                new Person(){ Id=3, Alder = 40, Navn = "dæflkgj lsdfkj lsdfkj dlsj"}
            };
                return p;
            }
        }



    }
   