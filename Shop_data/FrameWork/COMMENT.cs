namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENT")]
    public partial class COMMENT
    {
        [Key]
        public int Comment_ID { get; set; }

        [StringLength(50)]
        public string Customer_ID { get; set; }

        [StringLength(5)]
        public string Cake_ID { get; set; }

        public DateTime? Time_comment { get; set; }

        public string Content { get; set; }

        public virtual Cake Cake { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
