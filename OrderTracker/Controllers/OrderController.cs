using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/order")]
    public ActionResult Index()
    {
      return View();
    }
  }
}