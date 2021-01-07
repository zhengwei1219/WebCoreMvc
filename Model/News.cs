using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public DateTime PublishedTime { get; set; }
        public string PublishedBy { get; set; }
        public string Type { get; set; }
        public int BrowsedTimes { get; set; }
        public string Order { get; set; }
        
    }
}
