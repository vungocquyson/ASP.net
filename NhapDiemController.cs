using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test01.Models;

namespace test01.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Detail(sinhvien sv)
        //{
        //    sv.id = "sv001";
        //    sv.name = "vũ hải long";
        //    sv.mark = 9.5;
        //    return View(sv);
        //}
        //public ActionResult xuly()
        //{// sử dụng request
        //    string ma = Request["id"];
        //    string ten = Request["name"];
        //    double diem = Convert.ToDouble(Request["mark"]);
        //    ViewBag.Ma = ma;
        //    ViewBag.Ten = ten;
        //    ViewBag.Diem = diem;
        //    return View();
        //}

        //public ActionResult xuly(FormCollection data)
        //{// sử dụng forrm collection
        //    string ma = data["id"];
        //    string ten = data["name"];
        //    double diem = Convert.ToDouble(data["mark"]);
        //    ViewBag.Ma = ma;
        //    ViewBag.Ten = ten;
        //    ViewBag.Diem = diem;
        //    return View();
        //}

        //public ActionResult xuly(string id = "", string name = "", double mark = 0)
        //{// sử dụng action agrument
        //    ViewBag.Ma = id;
        //    ViewBag.Ten = name;
        //    ViewBag.Diem = mark;
        //    return View();
        //}

        public ActionResult xuly(sinhvien sv)
        {// sử dụng model
            ViewBag.Ma = sv.id;
            ViewBag.Ten = sv.name;
            ViewBag.Diem = sv.mark;
            return View();
        }
    }
}