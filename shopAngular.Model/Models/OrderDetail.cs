using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopAngular.Model.Models
{
    [Table("OrderDetails")]
    internal class OrderDetail
    {
       [Key]
        public int OrderID { get; set; }
     
        [Key]
        
        public int ProductID { get; set; }
       
        public int Quatiy { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

    }
}
