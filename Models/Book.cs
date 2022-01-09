using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Project.Models
{
    class Book
    {
        private static int _count = 0;
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            _count++;
            Code += Name.Substring(0, 2) + _count;
        }
    }
}
