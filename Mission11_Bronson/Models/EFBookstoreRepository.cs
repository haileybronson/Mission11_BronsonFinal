using System;
using System.Collections.Generic;

namespace Mission11_Bronson.Models;

public class EFBookstoreRepository : IBookstoreRepository
{  
    private BookstoreContext _context;

    public EFBookstoreRepository(BookstoreContext temp) {
        _context = temp;
    }
    public IQueryable<Book> Books => _context.Books;
}