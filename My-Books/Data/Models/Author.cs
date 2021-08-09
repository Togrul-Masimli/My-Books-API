using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}
