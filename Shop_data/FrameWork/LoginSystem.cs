namespace Shop_data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginSystem")]
    public partial class LoginSystem
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(32)]
        public string Pass { get; set; }

        public int? ID_Rule { get; set; }

        public virtual Chef Chef { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Manager Manager { get; set; }
    }
}
