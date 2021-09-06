using restwithapsnet.Model;
using System.Collections.Generic;

namespace restwithapsnet.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();
        Person Update(Person person);

        void Delete(long id);
    }
}
