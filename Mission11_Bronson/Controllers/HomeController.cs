using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11_Bronson.Models;
using Mission11_Bronson.Models.ViewModels;

namespace Mission11_Bronson.Controllers;

public class HomeController : Controller
{
    private IBookstoreRepository _repo;
    public HomeController(IBookstoreRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index(int pageNum, string bookType)
    {
        int pageSize = 10;

        var blah = new BooksListViewModel
        {
            Books = _repo.Books
            .OrderBy(x=> x.Title)
            .Skip((pageNum - 1) * pageSize)
            .Take(pageSize),

            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum, 
                ItemsPerPage = pageSize, 
                TotalItems = _repo.Books.Count()
            }
        };
            
        return View(blah);
    }

}
