using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace restwithapsnet.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutedContext context);

        Task Enrich(ResultExecutedContext context);
    }
}
