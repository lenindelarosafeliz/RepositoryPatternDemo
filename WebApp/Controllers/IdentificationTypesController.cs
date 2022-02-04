using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    public class IdentificationTypesController : Controller
    {
        private readonly ILogger<IdentificationTypesController> _logger;
        private readonly IIdentificationTypeService _identificationTypeService;

        public IdentificationTypesController(ILogger<IdentificationTypesController> logger,
                                            IIdentificationTypeService identificationTypeService)
        {
            _logger = logger;
            _identificationTypeService = identificationTypeService;
        }


        public IActionResult Index()
        {
            return View(_identificationTypeService.GetAll());
        }

        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var identificationTypeId = _identificationTypeService.GetById(id);
            if (identificationTypeId == null)
            {
                return NotFound();
            }

            return View(identificationTypeId);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IdentificationType identificationType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _identificationTypeService.Add(identificationType);                
                    return RedirectToAction(nameof(Index));
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            return View(identificationType);
        }



        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var identificationTypeId = _identificationTypeService.GetById(id);
            if (identificationTypeId == null)
            {
                return NotFound();
            }
            return View(identificationTypeId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IdentificationType identificationType)
        {
            if (id == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _identificationTypeService.Update(id, identificationType);                    
                    return RedirectToAction(nameof(Index));
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            return View(identificationType);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var identificationTypeId = _identificationTypeService.GetById(id);
            if (identificationTypeId == null)
            {
                return NotFound();
            }
            return View(identificationTypeId);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            try
            {
                _identificationTypeService.Remove(id);               
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}