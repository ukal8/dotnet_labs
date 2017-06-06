using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _50325_2_Kalinets.Models;

namespace _50325_2_Kalinets.Controllers {
  public class MenuController : Controller {
    // GET: Menu
    public ActionResult Index() {
      return View();
    }

    public PartialViewResult Main(string a = "Index", string c = "Home") {
      items.First(m => m.Controller == c).Active = "active";
      return PartialView(items);
    }

    public PartialViewResult UserInfo() {
      return PartialView();
    }

    public string Side() {
      return "<span>Боковая панель</span>";
    }

    public PartialViewResult Map() {
      return PartialView(items);
    }

    List<MenuItem> items = new List<MenuItem> {
      new MenuItem{Name="Домой", Controller="Home", Action="Index", Active=string.Empty},
      new MenuItem{Name="Каталог", Controller="Product", Action="List", Active=string.Empty},
      new MenuItem{Name="Администрирование", Controller="Admin", Action="Index", Active=string.Empty}
    };
  }
}