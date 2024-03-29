﻿using restwithapsnet.Model;
using System.Collections.Generic;

namespace restwithapsnet.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();
        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);
    }
}
