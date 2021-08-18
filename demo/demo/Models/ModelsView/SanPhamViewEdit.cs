using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Models.ModelsView
{
    public class SanPhamViewEdit
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string UrlAnh { get; set; }
        public int? GiaSP { get; set; }
        public string MoTa { get; set; }
        public int? MaDM { get; set; }
        public IEnumerable<SelectListItem> DanhMuc { get; set; }
    }
}