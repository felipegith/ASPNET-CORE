using System.Collections.Generic;


namespace restwithapsnet.Hypermedia.Abstract
{
    public interface ISupportHiperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
