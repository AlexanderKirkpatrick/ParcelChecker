using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
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
    public ActionResult Create(string dimensions)
    {
      Parcel myParcel = new Parcel(dimensions);
      return RedirectToAction("Index");
    }

  }
}