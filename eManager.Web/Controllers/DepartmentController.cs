using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManger.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataStore _db;
        public DepartmentController(IDepartmentDataStore db)
        {
            _db = db;
        }
        public ActionResult Detail(int id)
        {
            var model = _db.Departments.SingleOrDefault(d => d.Id == id);
            return View(model);
        }

    }
}
