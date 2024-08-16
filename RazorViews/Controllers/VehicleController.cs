using Microsoft.AspNetCore.Mvc;
using RazorViews.Models;

namespace RazorViews.Controllers;

[Route("[controller]")]
public class VehicleController : Controller
{
    [HttpGet("cars")]
    public IActionResult GetCars()
    {
        ListModel model = new("Cars", ["Audi", "Tesla", "BMW"]);
        return PartialView("_List", model);
    }
    
    [HttpGet("trucks")]
    public IActionResult GetTrucks()
    {
        ListModel model = new("Cars", ["Benz", "Tata", "Volvo"]);
        return PartialView("_List", model);
    }   
}