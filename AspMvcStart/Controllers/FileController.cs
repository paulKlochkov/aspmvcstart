using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Repository;
using Data.Common;
using AspMvcStart.Models;
namespace AspMvcStart.Controllers
{
    public class FileController : Controller
    {
        private IFileRepositry _fileRepository;

        public FileController(IFileRepositry repository)
        {
            _fileRepository = repository;
        }

        // GET: File
        public ActionResult Index()
        {
            IEnumerable<FileModel> model = _fileRepository.GetAll().Select(file => new FileModel(file)).ToList();
            return View(model);
        }

        // GET: File/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: File/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: File/Create
        [HttpPost]
        public ActionResult Create(FileModel model)
        {
            try
            {
                // TODO: Add insert logic here
                _fileRepository.Save(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: File/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: File/Edit/5
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

        // GET: File/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: File/Delete/5
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
