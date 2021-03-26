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
  }
}