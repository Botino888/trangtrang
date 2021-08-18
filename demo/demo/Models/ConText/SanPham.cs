namespace demo.Models.ConText
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string UrlAnh { get; set; }

        public int? GiaSP { get; set; }

        public string MoTa { get; set; }

        public int? MaDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
