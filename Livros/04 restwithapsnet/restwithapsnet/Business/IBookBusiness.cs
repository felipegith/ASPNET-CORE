using restwithapsnet.Model;
using System;
using System.Collections.Generic;


namespace restwithapsnet.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book FindById(long id);

        List<Book> FindAll();
        Book Update(Book book);

        void Delete(long id);
    }
}
