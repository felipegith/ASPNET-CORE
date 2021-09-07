using restwithapsnet.Hypermedia.Abstract;
using System.Collections.Generic;


namespace restwithapsnet.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
