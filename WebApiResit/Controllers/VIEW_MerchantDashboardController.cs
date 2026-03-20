using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class VIEW_MerchantDashboardController : Controller
    {

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VIEWMerchantDashboard_StoreActivity([System.Web.Http.FromBody] VIEW_MerchantDashboard AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_MerchantDashboard> data = new List<VIEW_MerchantDashboard>();
            try
            {
                data = VIEW_MerchantDashboard.VIEW_MerchantDashboard_StoreActivity(AC.enterpriseAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantDashboard_CheckOutActivity([System.Web.Http.FromBody] VIEW_MerchantDashboard AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_MerchantDashboard> data = new List<VIEW_MerchantDashboard>();
            try
            {
                data = VIEW_MerchantDashboard.MerchantDashboard_CheckOutActivity(AC.enterpriseAccNo,AC.AccountNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
	}
}