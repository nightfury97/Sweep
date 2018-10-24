namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Carts = new HashSet<Cart>();
            COMMENTs = new HashSet<COMMENT>();
            Customer_Payment_Methods = new HashSet<Customer_Payment_Methods>();
        }

        [Key]
        [StringLength(50)]
        public string Customer_ID { get; set; }

        [StringLength(20)]
        public string Customer_Name { get; set; }

        [StringLength(12)]
        public string Customer_Phone { get; set; }

        [StringLength(30)]
        public string Customer_Email { get; set; }

        public string Customer_Adress { get; set; }

        [StringLength(5)]
        public string Customer_Payment_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Payment_Methods> Customer_Payment_Methods { get; set; }

        public virtual LoginSystem LoginSystem { get; set; }
    }
}
