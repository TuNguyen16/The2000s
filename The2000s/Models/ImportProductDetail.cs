namespace The2000s.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportProductDetail")]
    public partial class ImportProductDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImportID { get; set; }

        public int? Amount { get; set; }

        public int? BuyPrice { get; set; }

        public virtual ImportProduct ImportProduct { get; set; }

        public virtual Product Product { get; set; }
    }
}
