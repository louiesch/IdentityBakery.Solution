using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IdentityBakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace IdentityBakery.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly IdentityBakeryContext _db;

    public FlavorsController(IdentityBakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      if (TreatId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() {TreatId = TreatId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}