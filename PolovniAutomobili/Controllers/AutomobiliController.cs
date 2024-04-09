using Microsoft.AspNetCore.Mvc;
using PolovniAutomobili.Contexts;
using PolovniAutomobili.Models;
using PolovniAutomobili.ViewModels;

namespace PolovniAutomobili.Controllers
{
    public class AutomobiliController : Controller
    {
        private readonly AutomobiliDbContext _dbContext;

        public AutomobiliController(AutomobiliDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult PregledAutomobila()
        {
            var model = new SviAutomobiliViewModel();
            var sviAutomobili = _dbContext.Automobil.ToList();
            model.SviAutomobili = sviAutomobili;
            return View(model);
        }

        public IActionResult DetaljiOAutomobilu(int id)
        {
            if(id <=0)
            {
                return BadRequest("Bad request");
            }

            var automobil = _dbContext.Automobil.FirstOrDefault(x => x.Id == id);

            if(automobil == null)
            {
                return BadRequest("Trazeni automobil ne postoji");
            }

            return View(automobil);
        }

        public IActionResult NoviAutomobil()
        {
            var model = new Automobil();

            return View(model);
        }

        public IActionResult DodajNoviAutomobil(Automobil automobil)
        {
            if(automobil == null)
            {
                return BadRequest("BadRequest");
            }

            _dbContext.Automobil.Add(automobil);
            _dbContext.SaveChanges();

            return RedirectToAction("PregledAutomobila");
        }
    }
}
