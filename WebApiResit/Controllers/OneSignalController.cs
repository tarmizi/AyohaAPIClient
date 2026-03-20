using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class OneSignalController : Controller
    {
        //
        // GET: /OneSignal/
        //public ActionResult Index()
        //{
        //    return View();
        //}





        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult OneSignalSendbyPlayerID(int ID)
        {


            bool success = true;
            string _Message = string.Empty;
            List<OneSignalModel> data = new List<OneSignalModel>();
            try
            {
                success = OneSignalModel.OneSignalSendBy_PlayerID(ID);
                //if(success)
                //{ success=SendEmail_VerifyRegistrationCode(CR_MykadNo, CR_Email); }
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
        public JsonResult OneSignalSendPushNotification(string MyKad)
        {


            bool success = true;
            string _Message = string.Empty;
            List<OneSignalModel> data = new List<OneSignalModel>();
            try
            {
                success = OneSignalModel.OneSignalSend_PushNotification(MyKad);
                //if(success)
                //{ success=SendEmail_VerifyRegistrationCode(CR_MykadNo, CR_Email); }
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }








        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult onesignalAPIAyohaNotificationUserProfileCreated([System.Web.Http.FromBody] OneSignalModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<OneSignalModel> data = new List<OneSignalModel>();
           
            try
            {
                data = OneSignalModel.onesignalAPI_AyohaNotification_UserProfileCreated(AP.AccountName,AP.PlayerID);
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