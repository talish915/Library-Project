using Library_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Project.Services
{
    class Library
    {
        public List<Book> BookList { get; set; }

        public void AddBook(string name, string authorName, int pageCount)
        {
            BookList.Add(new Book(name, authorName, pageCount));
        }

        public List<Book> FindAllBooksByName(string value)
        {
            return BookList.FindAll(n => n.Name.ToUpper().Contains(value.ToUpper()));
        }

        public void RemoveAllBooksByName(string value)
        {
            BookList.RemoveAll(n => n.Name.ToUpper().Contains(value.ToUpper()));
        }

        public List<Book> SearchBooks(string value)
        {
            return BookList.FindAll(n => n.Name.ToUpper().Contains(value.ToUpper()) || n.AuthorName.ToUpper().Contains(value.ToUpper()) || n.PageCount.ToString().ToUpper().Contains(value.ToUpper()));
        }

        public List<Book> FindAllBooksByPageCount(int min, int max)
        {
            return BookList.FindAll(n => n.PageCount >= min && n.PageCount <= max);
        }

        
    }
}
