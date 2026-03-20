using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementAnalsysController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementAnalsysInsertUpdate([System.Web.Http.FromBody] AdvertisementAnalsysModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementAnalsysModel> data = new List<AdvertisementAnalsysModel>();
            try
            {
                success = AdvertisementAnalsysModel.AdvertisementAnalsys_InsertUpdate(AP.SubscriberAccNo, AP.IPAddress,
 AP.EnterpriseAccNo, AP.AdvertisementCode, AP.AccessedPlatform);
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