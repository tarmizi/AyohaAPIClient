using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaNotificationMasterController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationMasterInsert([System.Web.Http.FromBody] AyohaNotificationMasterModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaNotificationMasterModel> data = new List<AyohaNotificationMasterModel>();
            try
            {
                success = AyohaNotificationMasterModel.AyohaNotificationMaster_Insert(I.ID, I.NotificationCode, I.NotificationTitle,I.NotificationBody, I.NotifcationImageName, I.NotificationFooterImageName, I.EnterpriseAccNo, I.EnterpriseHQAccNo, I.NotificationType, I.NotificationStatus, I.CreatedBy, I.SendToAudiencesCount,I.AudienceType,
            I.NotifcationImage, I.NotificationFooterImage, I.PlayerID, I.NotificationMedium, I.SubscriberAccNo, I.Source, I.TypeCRDB, I.EnterpriseName);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }








        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationMasterLoadByEnterpriseAccNo(string EnterpriseAccNo, string NotificationMedium, string NotificationYear, string NotificationMonth, string LoadNotificationType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationMasterModel> data = new List<AyohaNotificationMasterModel>();
            try
            {
                data = AyohaNotificationMasterModel.AyohaNotificationMaster_LoadByEnterpriseAccNo(EnterpriseAccNo, NotificationMedium, NotificationYear, NotificationMonth, LoadNotificationType);
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
        public JsonResult AyohaNotificationMasterRecentlyUsed(string EnterpriseAccNo, string NotificationMedium)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationMasterModel> data = new List<AyohaNotificationMasterModel>();
            try
            {
                data = AyohaNotificationMasterModel.AyohaNotificationMaster_RecentlyUsed(EnterpriseAccNo, NotificationMedium);
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
        public JsonResult AyohaNotificationMasterPNDashboard(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationMasterModel> data = new List<AyohaNotificationMasterModel>();
            try
            {
                data = AyohaNotificationMasterModel.AyohaNotificationMaster_PN_Dashboard(EnterpriseAccNo);
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