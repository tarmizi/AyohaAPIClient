using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class RedeemItemController : Controller
    {
        // GET: RedeemItem
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult RedeemItemgetByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<RedeemItemModel> data = new List<RedeemItemModel>();
            try
            {
                data = RedeemItemModel.RedeemItem_getByEnterpriseAccNo(EnterpriseAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
    }
}