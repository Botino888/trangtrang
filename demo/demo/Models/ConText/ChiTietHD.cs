namespace demo.Models.ConText
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public long DonGia { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
