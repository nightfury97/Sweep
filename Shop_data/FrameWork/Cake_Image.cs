namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cake_Image
    {
        [Key]
        public int Imange_ID { get; set; }

        [StringLength(5)]
        public string Cake_ID { get; set; }

        [Column("Cake_Image")]
        public string Cake_Image1 { get; set; }

        public virtual Cake Cake { get; set; }
    }
}
