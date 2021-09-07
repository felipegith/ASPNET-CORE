using System;

namespace restwithapsnet.Model
{
    
    public class BookVO 
    {

        public long Id { get; set; }

        public string Author { get; set; }
               
        public string Title { get; set; }
                
        public decimal Price { get; set; }
                
        public DateTime LaunchDate { get; set; }
    }
}
