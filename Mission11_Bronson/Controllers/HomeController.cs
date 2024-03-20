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

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10; 

        var bookstoreData = _repo.Books
            .OrderBy(x=> x.Title)
            .Skip((pageNum - 1) * pageSize)
            .Take(pageSize);
        return View(bookstoreData);
    }

}
