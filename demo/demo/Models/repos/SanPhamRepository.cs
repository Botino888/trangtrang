using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using demo.Models.ModelsView;
using demo.Models.ConText;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;

namespace demo.Models.repos
{
    public class SanPhamRepository
    {
        public SanPhamView1 addRowSP(string MaSP)
        {
            using (var ConText = new MyContext())
            {
                var SP = ConText.SanPhams.Find(MaSP);
                if (SP == null)
                    return null;
                else
                {
                    var DanhMuc = new DanhMucRepository();
                    var Sp1 = new SanPhamView1();
                    Sp1.MaSP = SP.MaSP;
                    Sp1.TenSP = SP.TenSP;
                    Sp1.GiaSP = SP.GiaSP;
                    Sp1.MaDM = SP.MaDM;
                    foreach(var t in DanhMuc.DMofSP())
                    {
                        if(int.Parse(t.Value)==Sp1.MaDM)
                        {
                            Sp1.DanhMuc = t.Text;
                            break;
                        }
                    }
                    
                    return Sp1;
                }
            }
        }
        public SanPhamViewEdit SpEdit(string MaSP)
        {
            using(var ConText = new MyContext())
            {
                var SP = ConText.SanPhams.Find(MaSP);
                if (SP == null)
                    return null;
                else
                {
                    var DanhMuc = new DanhMucRepository();
                    var SpEdit = new SanPhamViewEdit();
                    SpEdit.MaSP = SP.MaSP;
                    SpEdit.TenSP = SP.TenSP;
                    SpEdit.UrlAnh = SP.UrlAnh;
                    SpEdit.GiaSP = SP.GiaSP;
                    SpEdit.MoTa = SP.MoTa;
                    SpEdit.MaDM = SP.MaDM;
                    SpEdit.DanhMuc = DanhMuc.DMofSP();
                    return SpEdit;
                }
            }
        }

        public List<SanPhamView1> GetSanPham()
        {
            using(var Context = new MyContext())
            {
                var SpView = Context.SanPhams.AsNoTracking()
                    .Include("DanhMuc").ToList();
                if(SpView!=null)
                {
                    List<SanPhamView1> LSP = new List<SanPhamView1>();
                    foreach(SanPham t in SpView)
                    {
                        SanPhamView1 SP = new SanPhamView1();
                        SP.MaSP = t.MaSP;
                        SP.TenSP = t.TenSP;
                        SP.GiaSP = t.GiaSP;
                        SP.MaDM = t.MaDM;
                        SP.DanhMuc = t.DanhMuc.TenDM;
                        LSP.Add(SP);
                    }
                    return LSP;
                }
                return null;
            }    
        }
        
        public bool SuaSP(SanPhamViewEdit SpEdit)
        {
            using(var context= new MyContext())
            {
                if (SpEdit == null) return false;
                var Sp=context.SanPhams.Find(SpEdit.MaSP);
                Sp.TenSP = SpEdit.TenSP;
                Sp.UrlAnh = SpEdit.UrlAnh;
                Sp.GiaSP = SpEdit.GiaSP;
                Sp.MoTa = SpEdit.MoTa;
                Sp.MaDM = SpEdit.MaDM;
                context.SaveChanges();
                return true;
            }
        }

        public bool DeleteSp(string MaSP)
        {
            using(var context= new MyContext())
            {
                try
                {
                    var SP = context.SanPhams.Find(MaSP);
                    context.SanPhams.Remove(SP);
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool AddSp(SanPhamViewEdit SpAdd)
        {
            if (SpAdd.MaSP == null)
                return false;
            using(var context= new MyContext())
            {
                var Check = context.SanPhams.Find(SpAdd.MaSP);
                if (Check != null) return false;
                var Sp = new SanPham();
                Sp.MaSP = SpAdd.MaSP;
                Sp.TenSP = SpAdd.TenSP;
                Sp.UrlAnh = SpAdd.UrlAnh;
                Sp.GiaSP = SpAdd.GiaSP;
                Sp.MaDM = SpAdd.MaDM;
                context.SanPhams.Add(Sp);
                context.SaveChanges();
                return true;
            }    
        }
        //public addSanPhamEdit
    }
}