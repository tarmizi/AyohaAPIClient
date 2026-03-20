using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class SMSController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileGetVerifyString([System.Web.Http.FromBody] SMSModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SMSModel> data = new List<SMSModel>();
            try
            {
                data = SMSModel.AyohaUserProfile_GetVerifyString(AP.AccountNo, AP.PhoneNo, AP.LoginOS, AP.LoginIP, AP.PhoneModel, AP.PhoneImeiNo, AP.PhoneVersion, AP.PhonePlatform
            , AP.PhonePlatformVersion, AP.PhoneManufacturer, AP.PhoneSerial, AP.RawPhoneInfo, AP.PlayerID);
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
        public JsonResult DisasterNowVerifyTAC([System.Web.Http.FromBody] SMSModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SMSModel> data = new List<SMSModel>();
            try
            {
                data = SMSModel.DisasterNow_VerifyTAC( AP.PhoneNo,AP.PlayerID);
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