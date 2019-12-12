using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithEFCore.Models;

namespace WebAppWithEFCore.Controllers
{
    public class SampleBooksController : Controller
    {
        private readonly BooksContext _booksContext;
        public SampleBooksController(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }

        public async Task<string> CreateTheDatabase()
        {
            bool created = await _booksContext.Database.EnsureCreatedAsync();
            return $"created: {created}";
        }

        public async Task<string> UpdateDatabase()
        {
            await _booksContext.Database.MigrateAsync();
            return "db migrated";
        }
    }
}
