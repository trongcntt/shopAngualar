using shopAngular.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("Pages")]
    public  class Page : Auditable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Content { get; set; }

    }
}
