//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SweepCake
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cake()
        {
            this.Cake_Image = new HashSet<Cake_Image>();
            this.Cart_Item = new HashSet<Cart_Item>();
            this.COMMENTs = new HashSet<COMMENT>();
        }
    
        public string Cake_ID { get; set; }
        public string Cake_Name { get; set; }
        public string Cake_Type_Code { get; set; }
        public Nullable<double> Cake_Price { get; set; }
        public Nullable<double> Discount { get; set; }
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
