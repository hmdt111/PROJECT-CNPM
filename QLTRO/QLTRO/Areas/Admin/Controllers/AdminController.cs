using QLTRO.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTRO.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        QLnhatroEntities db = new QLnhatroEntities();
        // GET: Admin/Admin
        public ActionResult HoaDon()
        {
            List<HOADON> hoadon = db.HOADONs.ToList();
            return View(hoadon);
        }



        public ActionResult HopDong()
        {
            List<HOPDONG> hd = db.HOPDONGs.ToList();
            return View(hd);
        }

        public ActionResult NguoiDung()
        {
            List<NGUOIDUNG> nd = db.NGUOIDUNGs.ToList();
            return View(nd);
        }

        public ActionResult AddNguoiDung()
        {
            
            return View();
        }
        public ActionResult PhongTro()
        {
            List<PHONGTRO> pt = db.PHONGTROes.ToList();
            return View(pt);
        }
    }
}