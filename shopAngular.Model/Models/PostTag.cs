using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
       
        public int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual IEnumerable<Post> Posts { get; set; }
        public string TagID { get; set; }
        [ForeignKey("TagID")]
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}
