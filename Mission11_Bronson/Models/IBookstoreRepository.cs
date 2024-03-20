using System;
using System.Collections.Generic;

namespace Mission11_Bronson.Models;

    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books {get; }
    }
