using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Licenta.Models;

namespace Licenta.Controllers
{
    public class CategorieController : Controller
    {
        private ApplicationDbContext _context;

        public CategorieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Categorie
        public ViewResult Index()
        {
            var categorie = _context.Categorie.ToList();
            return View(categorie);
        }

        public ActionResult Detalii(int id)
        {
            var categorie = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (categorie == null)
                return HttpNotFound();

            return View(categorie);
        }
    
        
    }

    internal class ApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public object Categorie { get; internal set; }
        public object Customers { get; internal set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}