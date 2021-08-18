using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models.ConText;
using demo.Models.ModelsView;

namespace demo.Models.repos
{
    public class DanhMucRepository
    {
        public IEnumerable<SelectListItem> DMofSP()
        {
            using(var ConText=new MyContext())
            {
                List<SelectListItem> DanhMuc = ConText.DanhMucs.AsNoTracking().OrderBy(n => n.MaDM)
                    .Select(n =>
                    new SelectListItem
                    {
                        Value = n.MaDM.ToString(),
                        Text = n.TenDM
                    }).ToList() ;
                return new SelectList(DanhMuc, "Value", "Text");
            }
        }
    }
}