using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaScanQrCodeActivityController : Controller
    {
        [HttpPost]
      //  [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaScanQrCodeActivityInsertUpdate([System.Web.Http.FromBody] AyohaScanQrCodeActivityModel AM)
        {
            string success = "true";
            string _Message = string.Empty;

            List<AyohaScanQrCodeActivityModel> data = new List<AyohaScanQrCodeActivityModel>();
            try
            {

                success = AyohaScanQrCodeActivityModel.AyohaScanQrCodeActivity_InsertUpdate(AM.SubscriberAccNo, AM.QrCodeString, AM.EnterpriseAccNo, AM.Activity);

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