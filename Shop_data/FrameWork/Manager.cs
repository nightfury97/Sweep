namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manager")]
    public partial class Manager
    {
        [Key]
        [StringLength(50)]
        public string Manager_ID { get; set; }

        [StringLength(30)]
        public string Manager_Name { get; set; }

        [StringLength(12)]
        public string Manager_Phone { get; set; }

        public virtual LoginSystem LoginSystem { get; set; }
    }
}
