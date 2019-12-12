using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithEFCore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [StringLength(30)]
        public string Title { get; set; } = string.Empty;
        public string? Publisher { get; set; }

        [StringLength(20)]
        public string? Isbn { get; set; }

        public string? Foo { get; set; }
        public string? Bar { get; set; }
    }
}
