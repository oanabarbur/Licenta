using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Licenta.Models;

namespace Licenta.Controllers
{
    public class EchipamenteController : Controller
    {
        
        // GET: Echipamente
        public ActionResult Random()
        {
            var echipamente = new Echipamente() { Nume = "schiuri" };
            var categorie = new List<Categorie>
            {
                new Categorie { Nume = "schi"},
                new Categorie { Nume = "snowboard"}
            };

     //       var viewModel = new RandomEchipamenteViewModel
       //     {
         //       Echipamente = echipamente,
           //     Categorie = categorie
           // };
           return View(echipamente);

       //   return RedirectToAction("Index", "Home", new { page = 1, sortBy = "nume" });
        }


        public ActionResult ByPret(decimal pret) => Content("pret");

        //private ActionResult Content(decimal pret)
        //{
        //  throw new NotImplementedException();
        //}

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Nume";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}