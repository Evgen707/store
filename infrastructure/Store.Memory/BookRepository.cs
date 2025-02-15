using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {

        private readonly Book[] books = new[]
        {
            new Book(1, "Art of programming"),
            new Book(2, "Refactoring"),
            new Book(3, "Programming Language"),
        }

       public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(books => books.Title.Contains(titlePart))
                .ToArray();
        }
    }
}