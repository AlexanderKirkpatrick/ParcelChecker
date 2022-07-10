using Microsoft.AspNetCore.Mvc;
using ParcelCheck.Models;
using System.Collections.Generic;

namespace ParcelCheck.Controllers
{
  public class ParcelController : Controller
  {
    
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int width, int height, int length, int weight)
    {
      Parcel myParcel = new Parcel(width, height, length, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/parcels/delete")]
    public ActionResult DeleteAll()
    {
      Parcel.ClearAll();
      return View();
    }

  }
}