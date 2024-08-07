
using Microsoft.AspNetCore.Mvc;
using RazorViews.Models;

namespace RazorViews.Controllers;

[Route("[controller]")]
public class PersonController: Controller 
{
    [HttpGet]
    public IActionResult GetPerson()
    {
        Person person = new("Arjun", 28);
        return View(person);
    }
}