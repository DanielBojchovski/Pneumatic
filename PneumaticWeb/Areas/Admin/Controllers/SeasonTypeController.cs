using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pneumatic.DataAccess;
using Pneumatic.DataAccess.Repository.IRepository;
using Pneumatic.Models;
using Pneumatic.Utility;

namespace PneumaticWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class SeasonTypeController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public SeasonTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<SeasonType> objSeasonTypeList = _unitOfWork.SeasonType.GetAll();
            return View(objSeasonTypeList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SeasonType obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.SeasonType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "SeasonType created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var SeasonTypeFromDbFirst = _unitOfWork.SeasonType.GetFirstOrDefault(u => u.Id == id);

            if (SeasonTypeFromDbFirst == null)
            {
                return NotFound();
            }

            return View(SeasonTypeFromDbFirst);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SeasonType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.SeasonType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "SeasonType updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var SeasonTypeFromDbFirst = _unitOfWork.SeasonType.GetFirstOrDefault(u => u.Id == id);

            if (SeasonTypeFromDbFirst == null)
            {
                return NotFound();
            }

            return View(SeasonTypeFromDbFirst);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _unitOfWork.SeasonType.GetFirstOrDefault(u => u.Id == id);

            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.SeasonType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "SeasonType deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
