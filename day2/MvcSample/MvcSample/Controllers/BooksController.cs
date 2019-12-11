using Microsoft.AspNetCore.Mvc;
using MvcSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var book = new Book
            {
                BookId = 1,
                Title ="Professional C# 7",
                Publisher = "Wrox Press"
            };
            return View("Book", book);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public string Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                // show error
            }
            return book.ToString();
        }

        public async Task<IAsyncResult> Edit1()
        {
            var book = new Book();
            await this.TryUpdateModelAsync<Book>(book);
            if (this.TryValidateModel(book))
            {
                return Ok(book);
            }
            else
            {
                // error
                // return new StatusCodeResult(400);
            }
        }
    }
}
