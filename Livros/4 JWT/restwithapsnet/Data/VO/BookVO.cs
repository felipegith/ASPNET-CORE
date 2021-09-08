using restwithapsnet.Hypermedia;
using restwithapsnet.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace restwithapsnet.Model
{
    
    public class BookVO : ISupportHyperMedia
    {

        public long Id { get; set; }

        public string Author { get; set; }
               
        public string Title { get; set; }
                
        public decimal Price { get; set; }
                
        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
