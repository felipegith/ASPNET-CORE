using restwithapsnet.Model;
using restwithapsnet.Model.Base;
using System.Collections.Generic;

namespace restwithapsnet.Repository
{
    public interface IRepository<TipoGenerico> where TipoGenerico : BaseEntity
    {
        TipoGenerico Create(TipoGenerico item);

        TipoGenerico FindById(long id);

        List<TipoGenerico> FindAll();
        TipoGenerico Update(TipoGenerico item);

        void Delete(long id);

        bool Exists(long id);
    }
}
