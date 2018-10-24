namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cart_Item
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Cake_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cart_ID { get; set; }

        public int? Quantity { get; set; }

        public string Orther { get; set; }

        public virtual Cake Cake { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
