namespace demo.Models.ConText
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }
    }
}
