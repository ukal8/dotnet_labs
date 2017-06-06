using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _50325_2_Kalinets.Controllers {
  public class HomeController : Controller {
    // GET: Home
    public ActionResult Index() {
      SelectList Colors = new SelectList(Enum.GetValues(typeof(System.Drawing.KnownColor)));
      ViewBag.Colors = Colors;
      ViewBag.MyText = Request.QueryString["Colors"] ?? "Лабораторная работа №2";
      return View();
    }
  }
}