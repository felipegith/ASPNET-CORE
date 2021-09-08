using restwithapsnet.Data.Converter.Contract;
using restwithapsnet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restwithapsnet.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origem)
        {
            if (origem == null) return null;
            return new Book
            {
                Id = origem.Id,
                Author = origem.Author,
                LaunchDate = origem.LaunchDate,
                Price = origem.Price,
                Title = origem.Title
            };
        }

        public List<Book> Parse(List<BookVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }

        public BookVO Parse(Book origem)
        {
            if (origem == null) return null;
            return new BookVO
            {
                Id = origem.Id,
                Author = origem.Author,
                LaunchDate = origem.LaunchDate,
                Price = origem.Price,
                Title = origem.Title
            };
        }

        public List<BookVO> Parse(List<Book> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }
    }
}
