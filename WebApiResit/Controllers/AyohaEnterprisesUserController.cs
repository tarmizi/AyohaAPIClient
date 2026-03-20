using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class AyohaEnterprisesUserController : Controller
    {

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaEnterprisesUserLogin(string UseName, string Password, string LoginOS, string LoginIP,
            string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
            string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                data = AyohaEnterprisesUserModel.AyohaEnterprisesUser_Login(UseName, Password, LoginOS, LoginIP,
             PhoneModel, PhoneImeiNo, PhoneVersion, PhonePlatform, PhonePlatformVersion, PhoneManufacturer,
             PhoneSerial, RawPhoneInfo, PlayerID);
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
        public JsonResult AyohaEnterprisesUserLoadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                data = AyohaEnterprisesUserModel.AyohaEnterprisesUser_LoadByEnterpriseHQAccNo(EnterpriseHQAccNo);
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
        public JsonResult AyohaEnterprisesUserLoadByAccountNo(string AccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                data = AyohaEnterprisesUserModel.AyohaEnterprisesUser_LoadByAccountNo(AccountNo);
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
        public JsonResult AyohaEnterprisesUserCheckUserName(string UseName, string SerialPhoneNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                data = AyohaEnterprisesUserModel.AyohaEnterprisesUser_CheckUserName(UseName, SerialPhoneNo);
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
        public JsonResult AyohaEnterprisesUserInsertUpdate([System.Web.Http.FromBody] AyohaEnterprisesUserModel EU)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = AyohaEnterprisesUserModel.AyohaEnterprisesUser_InsertUpdate(EU.AyohaEnterpriseUserID, EU.AccountNo, EU.AccountName, EU.UseName, EU.Password
      , EU.Email, EU.PhoneNumber, EU.PicProfilePhoto64, EU.ModifiedBy, EU.EnterpriseAccNo, EU.UserType
      , EU.UserStatus, EU.PhotoName, EU.DOB, EU.SerialPhoneNo, EU.RowActive, EU.PlayerID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaEnterprisesUserUpdatePassword([System.Web.Http.FromBody] AyohaEnterprisesUserModel EU)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaEnterprisesUserModel> data = new List<AyohaEnterprisesUserModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = AyohaEnterprisesUserModel.AyohaEnterprisesUser_UpdatePassword(EU.AyohaEnterpriseUserID, EU.AccountNo,EU.ModifiedBy,EU.Password);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
    }


    
}