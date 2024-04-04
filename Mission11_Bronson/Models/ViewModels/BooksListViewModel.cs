using System;
using System.Collections.Generic;

namespace Mission11_Bronson.Models.ViewModels;

public class BooksListViewModel
{
    public IQueryable<Book> Books {get; set; }

    public PaginationInfo PaginationInfo {get; set; } = new PaginationInfo();
    
    public string? CurrentBookType { get; set; }
}