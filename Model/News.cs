using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("News")]
    [Serializable]
    public class News
    {
        public News()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public DateTime? PublishedTime { get; set; }
        public string PublishedBy { get; set; }
        public string Type { get; set; }
        public int? BrowsedTimes { get; set; }
        public string Order { get; set; }
        public string ImageUrl { get; set; }


    }
}
