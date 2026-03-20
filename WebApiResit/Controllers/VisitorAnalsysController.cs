using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class VisitorAnalsysController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VisitorAnalsysInsertUpdate([System.Web.Http.FromBody] VisitorAnalsysModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VisitorAnalsysModel> data = new List<VisitorAnalsysModel>();
            try
            {
                success = VisitorAnalsysModel.VisitorAnalsys_InsertUpdate(AP.SubscriberAccNo, AP.IPAddress,
 AP.EnterpriseAccNo, AP.AdvertisementCode, AP.AccessedPlatform,AP.Module);
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