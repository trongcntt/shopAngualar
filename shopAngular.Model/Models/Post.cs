using shopAngular.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("Posts")]
    public class Post:Auditable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Alias { get; set; }
        public int CategoryID { get; set; }
        //xet khoa ngoai
        [ForeignKey("CategoryID")]
        public virtual IEnumerable<PostCategory> PostCategories { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
    }
}
