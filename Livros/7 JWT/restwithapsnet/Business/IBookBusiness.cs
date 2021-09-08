using restwithapsnet.Model;

using System.Collections.Generic;


namespace restwithapsnet.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO FindById(long id);

        List<BookVO> FindAll();
        BookVO Update(BookVO book);

        void Delete(long id);
    }
}
