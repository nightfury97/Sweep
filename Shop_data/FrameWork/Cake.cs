namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cake()
        {
            Cake_Image = new HashSet<Cake_Image>();
            Cart_Item = new HashSet<Cart_Item>();
            COMMENTs = new HashSet<COMMENT>();
        }

        [Key]
        [StringLength(5)]
        public string Cake_ID { get; set; }

        [StringLength(50)]
        public string Cake_Name { get; set; }

        [StringLength(7)]
        public string Cake_Type_Code { get; set; }

        public double? Cake_Price { get; set; }

        public double? Discount { get; set; }

        [StringLength(50)]
        public string Cake_decripsion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cake_Image> Cake_Image { get; set; }

        public virtual Cake_Type Cake_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart_Item> Cart_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }
    }
}
