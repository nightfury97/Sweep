namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chef")]
    public partial class Chef
    {
        [Key]
        [StringLength(50)]
        public string Chef_ID { get; set; }

        [StringLength(30)]
        public string Chef_Name { get; set; }

        [StringLength(12)]
        public string Chef_Phone { get; set; }

        public virtual LoginSystem LoginSystem { get; set; }
    }
}
