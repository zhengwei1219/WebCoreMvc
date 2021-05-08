using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("FriendlyLink")]
    [Serializable]
    public class FriendlyLink
    {
        public FriendlyLink()
        {

        }
       public int Id { get; set; }
        public string LinkUrl { get; set; }
        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
