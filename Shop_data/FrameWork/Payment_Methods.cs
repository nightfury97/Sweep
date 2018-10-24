namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment_Methods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment_Methods()
        {
            Customer_Payment_Methods = new HashSet<Customer_Payment_Methods>();
        }

        [Key]
        [StringLength(2)]
        public string Payment_Method_Code { get; set; }

        [StringLength(30)]
        public string Payment_Method_Descripsion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Payment_Methods> Customer_Payment_Methods { get; set; }
    }
}
