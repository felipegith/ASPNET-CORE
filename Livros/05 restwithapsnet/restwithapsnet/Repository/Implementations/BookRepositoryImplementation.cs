using restwithapsnet.Model;
using restwithapsnet.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace restwithapsnet.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {

        private MySqlContext _context;

        public BookRepositoryImplementation(MySqlContext context)
        {
            _context = context;
        }
        public Book Create(Book books)
        {
            try
            {
                _context.Add(books);
                _context.SaveChanges();
            }
            catch (SystemException)
            {
                throw;
            }
            return books;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (SystemException)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Book Update(Book book)
        {
            if (!Exists(book.Id))
            {
                return null;
            }

            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(book.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (SystemException)
                {
                    throw;
                }
            }

            return book;
        }
    }
}
