using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _50325_2_Kalinets.Controllers {
  public class MenuController : Controller {
    // GET: Menu
    public ActionResult Index() {
      return View();
    }

    public PartialViewResult Main() {
      return PartialView();
    }

    public PartialViewResult UserInfo() {
      return PartialView();
    }

    public string Side() {
      return "<span>Боковая панель</span>";
    }

    public string Map() {
      return "<span>Карта сайта</span>";
    }
  }
}