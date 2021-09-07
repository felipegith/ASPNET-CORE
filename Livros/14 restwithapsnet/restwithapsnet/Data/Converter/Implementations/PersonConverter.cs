using restwithapsnet.Data.Converter.Contract;
using restwithapsnet.Data.VO;
using restwithapsnet.Model;
using System.Collections.Generic;
using System.Linq;

namespace restwithapsnet.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origem)
        {
            if (origem == null)
            {
                return null;
            }
            else
            {
                return new Person
                {
                    Id = origem.Id,
                    FirstName = origem.FirstName,
                    LastName = origem.LastName,
                    Address = origem.Address,
                    Gender = origem.Gender
                };
            }
        }

        public List<Person> Parse(List<PersonVO> origem)
        {
            if (origem == null)
            {
                return null;
            }
            else
            {
                return origem.Select(item => Parse(item)).ToList();
            }
        }

        public PersonVO Parse(Person origem)
        {
            if (origem == null)
            {
                return null;
            }
            else
            {
                return new PersonVO
                {
                    Id = origem.Id,
                    FirstName = origem.FirstName,
                    LastName = origem.LastName,
                    Address = origem.Address,
                    Gender = origem.Gender
                };
            }
        }

        public List<PersonVO> Parse(List<Person> origem)
        {
            if (origem == null)
            {
                return null;
            }
            else
            {
                return origem.Select(item => Parse(item)).ToList();
            }
        }
    }
}
