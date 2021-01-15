namespace The2000s.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportProduct")]
    public partial class ImportProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportProduct()
        {
            ImportProductDetails = new HashSet<ImportProductDetail>();
        }

        [Key]
        public int ImportID { get; set; }

        public int? SupplierID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportProductDetail> ImportProductDetails { get; set; }
    }
}
