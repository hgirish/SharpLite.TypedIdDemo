using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Domain;
using SharpLite.Domain.DataInterfaces;

namespace Demo.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            var books = _productRepository.GetAll().ToList();
            return View(books);
        }

        //
        // GET: /BookShelfs/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BookShelfs/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BookShelfs/Create

        [HttpPost]
        public ActionResult Create(Product book)
        {
            //try
            //{
            _productRepository.SaveOrUpdate(book);

            return RedirectToAction("Index");
            //}
            //catch (Exception exception)
            //{
            //  TempData["warning"] = exception.Message;
            //    return View();
            //}
        }

        //
        // GET: /BookShelfs/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BookShelfs/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BookShelfs/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BookShelfs/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
