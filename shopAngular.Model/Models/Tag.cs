using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Type { get; set; }
        [Required]
        [MaxLength(50)]
        public virtual PostTag PostTag { get; set; }
    }
}
