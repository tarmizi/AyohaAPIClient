using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaNotificationController : Controller
    {



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationLoadByNotificationCode(string NotificationCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationModel> data = new List<AyohaNotificationModel>();
            try
            {
                data = AyohaNotificationModel.AyohaNotification_LoadByNotificationCode(NotificationCode, EnterpriseAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationModel> data = new List<AyohaNotificationModel>();
            try
            {
                data = AyohaNotificationModel.AyohaNotification_LoadBySubscriberAccNo(SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationIsReadUpdate([System.Web.Http.FromBody] AyohaNotificationModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaNotificationModel> data = new List<AyohaNotificationModel>();
            try
            {
                success = AyohaNotificationModel.AyohaNotification_IsReadUpdate(I.SubscriberAccNo, I.ID, I.IsRead);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationUserRowStatusUpdate([System.Web.Http.FromBody] AyohaNotificationModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaNotificationModel> data = new List<AyohaNotificationModel>();
            try
            {
                success = AyohaNotificationModel.AyohaNotification_UserRowStatusUpdate(I.SubscriberAccNo, I.ID, I.UserRowStatus);
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