using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IdentityBakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace IdentityBakery.Controllers
{
  public class TreatsController : Controller
  {
    private readonly IdentityBakeryContext _db;

    public TreatsController(IdentityBakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}