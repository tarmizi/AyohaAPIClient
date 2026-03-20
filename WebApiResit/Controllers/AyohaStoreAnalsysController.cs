using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStoreAnalsysController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreAnalsysInsertUpdate([System.Web.Http.FromBody] AyohaStoreAnalsysModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreAnalsysModel> data = new List<AyohaStoreAnalsysModel>();
            try
            {
                success = AyohaStoreAnalsysModel.AyohaStoreAnalsys_InsertUpdate(AP.SubscriberAccNo, AP.IPAddress,
 AP.EnterpriseAccNo, AP.AccessedPlatform);
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