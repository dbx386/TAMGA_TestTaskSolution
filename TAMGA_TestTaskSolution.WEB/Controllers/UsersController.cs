using Application.Services.DTOs.People;
using Application.Services.People;
using Domain.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace TAMGA_TestTaskSolution.WEB.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ActionResult> Index()
        {
            var users = await _userService.GetAsync();
            return View((object)users);
        }

        public ActionResult Details(Guid id)
        {

            return View(_userService.FindById(id));
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(UserDTO newUser)
        {

            if (ModelState.IsValid)
            {
                _userService.Create(newUser);
                return RedirectToAction("Index");                
            }
            else
            {
                return PartialView();
            }
        }

        public ActionResult Edit(Guid id)
        {
            var findedUser = _userService.FindById(id);

            return View(findedUser);
        }

        [HttpPost]
        public ActionResult Edit(Guid id, UserDTO user)
        {
            try
            {
                // TODO: Add update logic here
                _userService.Update(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {

            return View(_userService.FindById(id));
        }

        [HttpPost]
        public ActionResult Delete(Guid id, UserDTO user)
        {
            try
            {
                _userService.Remove(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
