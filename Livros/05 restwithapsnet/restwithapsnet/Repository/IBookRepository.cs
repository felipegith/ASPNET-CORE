using restwithapsnet.Model;
using System;
using System.Collections.Generic;


namespace restwithapsnet.Repository
{
    public interface IBookRepository
    {
        Book Create(Book books);

        Book FindById(long id);

        List<Book> FindAll();
        Book Update(Book book);

        void Delete(long id);

        bool Exists(long id);
    }
}
