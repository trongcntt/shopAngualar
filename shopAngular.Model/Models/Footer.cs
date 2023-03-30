using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("footers")]
    public class Footer
    {
        [Key]
       [MaxLength(50)]
        public String ID { get; set; }
        [Required]
        public String Content { get; set; }
    }
}
