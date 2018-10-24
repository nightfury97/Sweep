namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            Cart_Item = new HashSet<Cart_Item>();
        }

        [StringLength(50)]
        public string Customer_ID { get; set; }

        [Key]
        public int Cart_ID { get; set; }

        [StringLength(7)]
        public string Customer_Payment_ID { get; set; }

        public DateTime? Payment_time { get; set; }

        [StringLength(50)]
        public string Shipping_Address { get; set; }

        [StringLength(200)]
        public string Customer_Requirements { get; set; }

        public int? Cart_Status { get; set; }

        public double? Total { get; set; }

        [StringLength(50)]
        public string Driver_ID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Driver Driver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart_Item> Cart_Item { get; set; }
    }
}
