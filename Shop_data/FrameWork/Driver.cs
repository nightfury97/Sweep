namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        [StringLength(50)]
        public string Driver_ID { get; set; }

        [StringLength(30)]
        public string Driver_Name { get; set; }

        [StringLength(12)]
        public string Driver_Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual LoginSystem LoginSystem { get; set; }
    }
}
