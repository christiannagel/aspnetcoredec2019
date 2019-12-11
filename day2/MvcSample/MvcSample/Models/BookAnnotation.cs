using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.Models
{
    [System.ComponentModel.DataAnnotations.]
    public class BookAnnotation
    {
        public int BookId { get; set; }

        [StringLength(20)]
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
