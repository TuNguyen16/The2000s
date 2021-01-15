namespace The2000s.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int? Amount { get; set; }

        public int? Price { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
