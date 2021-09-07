using System.Collections.Generic;


namespace restwithapsnet.Hypermedia.Abstract
{
    public interface ISupportHiperMedia
    {
        List<HypermediaLink> Links { get; set; }
    }
}
