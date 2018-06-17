using Domain.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TAMGA_TestTaskSolution.WEB.Controllers
{
    public class HomeController : Controller
    {             
        public ActionResult Index()
        {
           
            return View();
        }
    }
}