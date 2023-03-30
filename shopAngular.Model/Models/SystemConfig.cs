using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int ValueSInt { get; set; }
    }
}
