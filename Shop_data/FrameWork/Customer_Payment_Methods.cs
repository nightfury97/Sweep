namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer_Payment_Methods
    {
        [Key]
        [StringLength(7)]
        public string Customer_Payment_ID { get; set; }

        [StringLength(50)]
        public string Customer_ID { get; set; }

        [StringLength(2)]
        public string Payment_Menthod_Code { get; set; }

        [StringLength(16)]
        public string Card_Number { get; set; }

        [StringLength(4)]
        public string Date_from { get; set; }

        [StringLength(4)]
        public string Date_to { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Payment_Methods Payment_Methods { get; set; }
    }
}
