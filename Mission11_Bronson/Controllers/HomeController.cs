using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11_Bronson.Models;

namespace Mission11_Bronson.Controllers;

public class HomeController : Controller
{
    private IBookstoreRepository _repo;
    public HomeController(IBookstoreRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
        var bookstoreData = _repo.Books;
        return View(bookstoreData);
    }

}
