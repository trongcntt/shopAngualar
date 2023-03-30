using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("VisitotStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }

        public string IPAdress { get; set; }
    }
}
