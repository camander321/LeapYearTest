using Microsoft.AspNetCore.Mvc;
using System;

namespace LeapYear.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string year = Request.Form["year"];
      bool isLeapYear = LeapYear.IsLeapYear(Int32.Parse(year));
      string msg = year;
      if (isLeapYear)
      {
        msg += " is a leap year!";
      }
      else
      {
        msg += " is not a leap year!";
      }
      return View("Index", msg);
    }
  }
}
